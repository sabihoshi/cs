using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MathOp = System.Math;

namespace Math.Classes
{
    public static class Tables
    {
        public static void CreateTable(this DataGrid dg, Statistics statistics)
        {
            dg.Columns.Clear();
            dg.Items.Clear();

            // The columns and bindings for the table
            var columns = new Dictionary<string, string>
            {
                {"X", "X"},
                {"P(x)", "Probability"},
                {"μ", "Mean"},
                {"x-μ", "MeanMinusX"},
                {"(x-μ)²", "MeanMinusXSquared"},
                {"(μ-x)²P(x)", "MeanMinusXSquaredProbability"}
            };

            foreach (var column in columns)
            {
                dg.Columns.Add(new DataGridTextColumn()
                {
                    Header = column.Key,
                    Binding = new Binding(column.Value) { StringFormat = "n2" }
                });
            }

            foreach (var sample in statistics.Population)
                dg.Items.Add(new Table.Sampling(sample, statistics.Mean));
        }

        public class Table
        {
            public class Sampling
            {
                public Sampling(Sample sample, double mean)
                {
                    X = sample.X;
                    Probability = sample.Probability;
                    P = sample.P;
                    Mean = mean;
                }

                public double Mean { get; set; }
                public double MeanMinusX => X - Mean;
                public double MeanMinusXSquared => MeanMinusX * MeanMinusX;
                public double MeanMinusXSquaredProbability => MeanMinusXSquared * (P.Item1 / (double)P.Item2);
                public Tuple<int, int> P { get; set; }
                public string Probability { get; set; }
                public double X { get; set; }
            }
        }
    }

    public class Sample
    {
        public Sample(double x, Tuple<int, int> probability)
        {
            X = x;
            P = probability;
        }

        public Tuple<int, int> P { get; set; }
        public string Probability => $"{P.Item1}/{P.Item2}";
        public double X { get; set; }
    }

    public class Statistics
    {
        public List<Sample> Population = new List<Sample>();
        public double Deviation => MathOp.Sqrt(Variance);
        public double Mean => Population.Select(x => x.X).Average();
        public double Variance => Population.Average(x => MathOp.Pow(x.X - Mean, 2));

        public Statistics(IEnumerable<IEnumerable<int>> input)
        {
            var population = input.ToList();
            var count = population.Count();
            Population = population
                        .Select(x => new Sample(x.Average(), new Tuple<int, int>(1, count)))
                        .ToList();
        }
    }
}