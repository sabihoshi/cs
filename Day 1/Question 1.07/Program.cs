using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int twice = x * 2;
            int square = x ^ 2;
            int half = x / 2;
            Console.WriteLine("Double: {0}", twice);
            Console.WriteLine("Square: {0}", square);
            Console.WriteLine("Half: {0}", half);
            Console.ReadKey();
        }
    }
}
