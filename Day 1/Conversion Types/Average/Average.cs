using System;
using System.Collections.Generic;

namespace Conversion_Types
{
    internal class Average
    {
        private static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, avg, sum;
            var numbers = new List<int>();
            Console.WriteLine("Enter 5 Numbers:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine());
            numbers.Add(n1);
            numbers.Add(n2);
            numbers.Add(n3);
            numbers.Add(n4);
            numbers.Add(n5);
            sum = (n1 + n2 + n3 + n4 + n5);
            avg = (sum / 5);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.ReadLine();
        }
    }
}