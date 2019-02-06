using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            double diameter = radius * 2;
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (radius ^ 2);
            Console.WriteLine(String.Format("Diameter: {0:0.00}", diameter));
            Console.WriteLine(String.Format("Circumference: {0:0.00}", circumference));
            Console.WriteLine(String.Format("Area: {0:0.00}", area));
            Console.ReadKey();
        }
    }
}
