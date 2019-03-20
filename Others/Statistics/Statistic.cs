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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
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

        private void GetResult_Click(object sender, EventArgs e)
        {
            IEnumerable<IEnumerable<int>> result;
            var inputList = InputBox.Text.Split(new[] {','}
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;
            if (ReplacementCheck.Checked)
                result = GetPermutationsWithRept(inputList, (int)SampleSize.Value);
            else
                result = GetPermutations(inputList, (int)SampleSize.Value);

            ResultBox.Clear();
            var dict = new Dictionary<string, double> ();
            string.Join(", ", result.Select(inner => inner.Average()).Distinct());
            foreach (var item in result)
            {
                if (!dict.ContainsValue(item.Average()))
                {
                    dict.Add(string.Join(", ", item), item.Average());
                }
            }
            foreach (var item in result)
            {
                if (!dict.ContainsValue(item.Average().ToString()))
                {
                    dict.Add(string.Join(", ", item), item.Average().ToString());

                    ResultBox.AppendText(
                        $"{string.Join(", ", item).PadRight(8)} {item.Average().ToString().PadRight(8)} {Environment.NewLine}");
                }
            }
        }
    }
}
}