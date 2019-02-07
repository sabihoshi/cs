using System;

namespace Question_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in pounds");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double grams = pounds * 454;
            Console.WriteLine("Weight: {0}g", grams);
            Console.ReadKey();
        }
    }
}