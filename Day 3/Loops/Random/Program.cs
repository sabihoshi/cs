using System;

namespace Rand
{
    internal class Program
    {
        private static Random r = new Random();

        private static int Rand()
        {
            int n = r.Next();
            return n;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Generated numbers are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Rand());
            }
            Console.ReadKey();
        }
    }
}