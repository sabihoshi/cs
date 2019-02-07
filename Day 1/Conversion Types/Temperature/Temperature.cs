using System;

namespace Conversion_Types
{
    internal class Temperature
    {
        private static void Main(string[] args)
        {
            int celsius, faren;
            Console.WriteLine("Etner the Temperature in Celsius(C) > ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Farenheit is (F): " + faren);
            Console.ReadKey();
        }
    }
}