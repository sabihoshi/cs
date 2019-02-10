using System;

namespace Question_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char letter;
            Console.WriteLine("Please input your letter");
            letter = char.ToLower(Convert.ToChar(Console.ReadLine()));

            if (letter == 'a' || letter == 'b' || letter == 'c')
                Console.WriteLine("2");
            else if (letter == 'd' || letter == 'e' || letter == 'f')
                Console.WriteLine("3");
            else if (letter == 'g' || letter == 'h' || letter == 'i')
                Console.WriteLine("4");
            else if (letter == 'j' || letter == 'k' || letter == 'l')
                Console.WriteLine("5");
            else if (letter == 'm' || letter == 'n' || letter == 'o')
                Console.WriteLine("6");
            else if (letter == 'p' || letter == 'q' || letter == 'r' || letter == 's')
                Console.WriteLine("7");
            else if (letter == 't' || letter == 'u' || letter == 'v')
                Console.WriteLine("8");
            else if (letter == 'w' || letter == 'x' || letter == 'y')
                Console.WriteLine("9");
            else if (letter == 'z')
                Console.WriteLine("That letter does not exist in a telephone dial");
            else
                Console.WriteLine("You didn't enter a letter!");
            Console.ReadKey();
        }
    }
}