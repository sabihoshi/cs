using System;

namespace Question_2._05
{
    internal class Program
    {
        static public void Cart(int flowers, int blanket, int pillow, int clothes, int pencil, double subTotal, double total)
        {
            Console.WriteLine("Cart");
            if (flowers > 0)
                Console.WriteLine("{0} Flowers: ${1:0.00}", flowers, flowers * 2.32);
            if (blanket > 0)
                Console.WriteLine("{0} Blanket: ${1:0.00}", blanket, blanket * 2.32);
            if (pillow > 0)
                Console.WriteLine("{0} Pillow: ${1:0.00}", pillow, pillow * 2.32);
            if (clothes > 0)
                Console.WriteLine("{0} Clothes: ${1:0.00}", clothes, clothes * 2.32);
            if (pencil > 0)
                Console.WriteLine("{0} Pencil: ${1:0.00}", pencil, pencil * 2.32);
            Console.WriteLine("\nSubtotal: ${0}", subTotal);
            Console.WriteLine("VAT: ${0} (12%)", subTotal * 0.12);
            Console.WriteLine("Total: ${0}", total);
        }

        private static void Main(string[] args)
        {
            int itemCount, choice, flowers = 0, blanket = 0, pillow = 0, clothes = 0, pencil = 0;
            double price = 0, subTotal = 0, addTotal = 0, total = 0, tended = 0;
        purchase:
            Console.WriteLine("Welcome to the Kat store\n");
            Console.WriteLine("[0] Checkout");
            Console.WriteLine("[1] Flowers $2.32");
            Console.WriteLine("[2] Blanket $5.21");
            Console.WriteLine("[3] Pillow $3.42");
            Console.WriteLine("[4] Clothes $7.35");
            Console.WriteLine("[5] Pencil $1.00");
            Console.WriteLine("Current total: ${0:0.00}", total);

            Console.WriteLine("Please choose what you want to buy");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 0)
            {
                Console.WriteLine("How many items?");
                itemCount = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        goto checkout;
                    case 1:
                        flowers += itemCount;
                        price = 2.32;
                        break;

                    case 2:
                        blanket += itemCount;
                        price = 5.21;
                        break;

                    case 3:
                        pillow += itemCount;
                        price = 3.42;
                        break;

                    case 4:
                        clothes += itemCount;
                        price = 7.35;
                        break;

                    case 5:
                        pencil += itemCount;
                        price = 1;
                        break;

                    default:
                        break;
                }
                addTotal = itemCount * price;
                subTotal += addTotal;
                total = subTotal + (subTotal * 0.12);
                Console.Clear();
                Cart(flowers, blanket, pillow, clothes, pencil, subTotal, total);
                Console.WriteLine("\nCheckout? (0) or Add more items (1)");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 0)
                    goto checkout;
                else
                    goto purchase;
            }
        checkout:
            Cart(flowers, blanket, pillow, clothes, pencil, subTotal, total);
            Console.WriteLine("Enter how much money you will pay");
            tended = Convert.ToDouble(Console.ReadLine());
            if (tended < total)
            {
                Console.WriteLine("You do not have enough money to complete the purchase! Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                goto checkout;
            }
            Console.WriteLine("Amount paid: ${0:0.00}", tended);
            Console.WriteLine("Change: ${0:0.00}", tended - total);
            Console.ReadKey();
        }
    }
}