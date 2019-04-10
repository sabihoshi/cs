using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Math.Classes;

namespace Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static IEnumerable<IEnumerable<T>>
            GetPermutationsWithRept<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] {t});
            return GetPermutationsWithRept(list, length - 1)
               .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] {t2}));
        }

        private static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] {t});
            return GetPermutations(list, length - 1)
               .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] {t2}));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            IEnumerable<IEnumerable<int>> result;
            var inputList = Population.Text.Split(new[] {','}
              , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (Replacement.IsChecked ?? false)
                result = GetPermutationsWithRept(inputList, SampleSize.Value ?? 2);
            else
                result = GetPermutations(inputList, SampleSize.Value ?? 2);
            if (Combine.IsChecked ?? false)
            {
                var count = result.Count();
                var test = new Statistics()
                {
                    Population = result
                                .GroupBy(inner => inner.Average())
                                .Select(g => new Sample(g.First().Average(), new Tuple<int, int>(g.Count(), count)))
                                .ToList()
                };
                SDGrid.ItemsSource = test.Population;
            }
            else
            {
                //var dict = result
                //          .Select(x => x.Average())
                //          .ToList(x => x, y => 1);
                //SDGrid.ItemsSource = dict;
            }
        }

    }
}
