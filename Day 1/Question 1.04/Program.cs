using System;

namespace Question_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter how many hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            int days = hours / 24;
            int weeks = days / 7;
            days %= 7;
            hours %= 24;

            Console.WriteLine("{0} Weeks, {1} Days, {2} Hours", weeks, days, hours);
            Console.ReadKey();
        }
    }
}