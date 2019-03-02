using System;

namespace Question_2._04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your integer 1-3999");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y < 1)
                Console.WriteLine("Number cannot be below 1!");
            else if (y > 3999)
                Console.WriteLine("Number cannot be above 3999!");
            else
            {
                int m = y / 1000;
                y %= 1000;
                int d = y / 500;
                y %= 500;
                int c = y / 100;
                y %= 100;
                int l = y / 50;
                y %= 50;
                int x = y / 10;
                y %= 10;
                int v = y / 5;
                int i = y % 5;

                string M = new String('M', m);
                string D = new string('D', d);
                string C = new string('C', c);
                string L = new string('L', l);
                string X = new string('X', x);
                string V = new string('V', v);
                string I = new string('I', i);

                if (c == 4)
                {
                    if (d == 1)
                    {
                        D = "CM";
                        C = "";
                    }
                    else
                        C = "CD";
                }
                if (x == 4)
                {
                    if (l == 1)
                    {
                        L = "XC";
                        X = "";
                    }
                    else
                        X = "XL";
                }
                if (i == 4)
                {
                    if (v == 1)
                    {
                        V = "IX";
                        I = "";
                    }
                    else
                        I = "IV";
                }
                Console.WriteLine(M + D + C + L + X + V + I);
            }
            Console.ReadKey();
        }
    }
}