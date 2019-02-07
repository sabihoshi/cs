using System;

namespace Question_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your value > ");
            double centimeters = Convert.ToDouble(Console.ReadLine());
            double inches = centimeters / 2.54;
            double feet = inches / 12;
            Console.WriteLine(String.Format("Inches: {0:0.00}", inches));
            Console.WriteLine(String.Format("Feet: {0:0.00}", feet));
            Console.ReadKey();
        }
    }
}