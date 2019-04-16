using Math.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

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

        private void CalculateDeviation(object sender, RoutedEventArgs e)
        {
            IEnumerable<IEnumerable<int>> result;
            var inputList = Population.Text.Split(new[] { ',' }
              , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (Replacement.IsChecked ?? false)
                result = GetPermutationsWithRept(inputList, SampleSize.Value ?? 2);
            else
                result = GetPermutations(inputList, SampleSize.Value ?? 2);

            var res = new Statistics(result);
            SdGrid.CreateTable(res);

            Variance.Text = res.Variance.ToString("n2");
            Deviation.Text = res.Deviation.ToString("n2");
        }
    }
}