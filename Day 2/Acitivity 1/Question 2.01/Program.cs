using System;

namespace Question_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x, y;
            string oper;
            Console.WriteLine("Enter your x integer");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your y integer");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation");
            oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    break;

                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine("The denominator cannot be 0!");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    }
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    break;

                case "%":
                    Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
                    break;

                default:
                    Console.WriteLine("That operation is invalid!");
                    break;
            }
            Console.ReadKey();
        }
    }
}