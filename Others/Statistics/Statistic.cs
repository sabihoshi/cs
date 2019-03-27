using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Statistic : MaterialSkin.Controls.MaterialForm
    {
        public Statistic()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }

        private static IEnumerable<IEnumerable<T>>
            GetPermutationsWithRept<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutationsWithRept(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private void GetResults_Click(object sender, EventArgs e)
        {
            IEnumerable<IEnumerable<int>> result;
            var inputList = InputBox.Text.Split(new[] {','}
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            ;
            if (ReplacementCheck.Checked)
                result = GetPermutationsWithRept(inputList, (int)SampleSize.Value);
            else
                result = GetPermutations(inputList, (int)SampleSize.Value);

            OutputBox.Clear();
            var dict = result
                .GroupBy(inner => inner.Average())
                .ToDictionary(group => group.First().Average(), group => group.Count());
            foreach (var item in dict)
            {
                OutputBox.AppendText($"{item.Key.ToString().PadRight(8)} {item.Value}/{result.Count()} {Environment.NewLine}");
            }

            SampleBox.Clear();
            foreach (var item in result)
            {
                SampleBox.AppendText($"{string.Join(", ", item)} {Environment.NewLine}");
            }
        }
    }
}