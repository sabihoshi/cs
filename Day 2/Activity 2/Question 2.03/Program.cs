using System;

namespace Question_2._03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please input x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input y");
            y = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                if (y == 0)
                    Console.WriteLine("the Origin");
                else
                    Console.WriteLine("x axis");
            }
            else if (y == 0)
                Console.WriteLine("y axis");
            else if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine("Quadrant I");
                else
                    Console.WriteLine("Quadrant II");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("Quadrant IV");
                else
                    Console.WriteLine("Quadrant III");
            }
            Console.ReadKey();
        }
    }
}