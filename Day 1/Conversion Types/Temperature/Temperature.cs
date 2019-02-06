using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Types
{
    class Temperature
    {
        static void Main(string[] args)
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
