using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first integer > ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer > ");
            int y = Convert.ToInt32(Console.ReadLine());
            int twice = x * 2;
            int quarter = x / 4;
            int square = x ^ 2;
            int half = x / 2;
            Console.WriteLine("{0}'s Double: {1}", x, twice);
            Console.WriteLine("{0}'s Square: {1}", x, square);
            Console.WriteLine("{0}'s Half: {1}", x, half);
            Console.WriteLine("{0}'s Quarter: {1}\n", x, quarter);
            twice = y * 2;
            quarter = y / 4;
            square = y ^ 2;
            half = y / 2;
            Console.WriteLine("{0}'s Double: {1}", y, twice);
            Console.WriteLine("{0}'s Square: {1}", y, square);
            Console.WriteLine("{0}'s Half: {1}", y, half);
            Console.WriteLine("{0}'s Quarter: {1}", y, quarter);
            Console.ReadKey();
        }
    }
}
