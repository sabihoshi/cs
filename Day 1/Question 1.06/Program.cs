using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of days");
            int days = Convert.ToInt32(Console.ReadLine());
            int months = days / 30;
            int years = months / 12;
            days %= 30;
            months %= 12;
            Console.WriteLine("{0} years, {1} months, {1} days.", years, months, days);
            Console.ReadKey();
        }
    }
}
