using System;

namespace Question_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter miles > ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double feet = miles * 5280;
            double inches = feet * 12;
            double centimeters = inches * 2.54;
            double kilometers = centimeters / 100000;
            Console.WriteLine(String.Format("{0:0.00}", kilometers));
            Console.ReadKey();
        }
    }
}