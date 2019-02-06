using System;

namespace Conversion_Types
{
    class Formatting
    {
        static void Main(string[] args)
        {
            string value1 = "Dot";
            string value2 = "Net";
            string value3 = "Sample";
            double sum = 123.56789;
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
            Console.WriteLine(String.Format("{0:0.00}", sum));
            Console.ReadKey();
        }
    }
}
