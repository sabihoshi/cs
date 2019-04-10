using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOp = System.Math;

namespace Math.Classes
{
    public class Statistics
    {
        public List<Sample> Population = new List<Sample>();
        public double       Mean      => Population.Select(x => x.X).Average();
        public double       Variance  => Population.Sum(x => MathOp.Pow(x.X - Mean, 2));
        public double       Deviation => MathOp.Sqrt(Variance);
    }

    public class Sample
    {
        public  double          X           { get; set; }
        private Tuple<int, int> P           { get; set; }
        public  string          Probability => $"{P.Item1}/{P.Item2}";

        public Sample(double x, Tuple<int, int> probability)
        {
            X = x;
            P = probability;
        }
    }
}