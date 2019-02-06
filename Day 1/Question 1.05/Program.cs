using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds / 60;
            int hours = minutes / 60;
            seconds %= 60;
            minutes %= 60;
            Console.WriteLine("{0} hours, {1} minutes, {2} seconds.", hours, minutes, seconds);
            Console.ReadKey();
        }
    }
}
