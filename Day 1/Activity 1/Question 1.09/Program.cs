using System;

namespace Question_9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter in pints > ");
            double pints = Convert.ToDouble(Console.ReadLine());
            double gills = pints * 4;
            double quarts = pints / 2;
            double gallons = pints / 8;
            Console.WriteLine(String.Format("Gills: {0:0.00}", gills));
            Console.WriteLine(String.Format("Quarts: {0:0.00}", quarts));
            Console.WriteLine(String.Format("Gallons: {0:0.00}", gallons));
            Console.ReadKey();
        }
    }
}