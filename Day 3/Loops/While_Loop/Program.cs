using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 0, y = 1;
            while (y < 10)
            {
                i += y;
                y++;
                Console.WriteLine("{0} + {1} = {2}", i - y, y - 1, i);
            }
            Console.WriteLine("Sum of 1-10 = {0}", i);
            Console.ReadKey();
        }
    }
}