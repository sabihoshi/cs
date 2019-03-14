using System;

namespace Switch
{
	internal class Calculate
	{
		private static void Main(string[] args)
		{
			int Num1, Num2, result;
			char option;
			Console.WriteLine("Enter the first Number: ");
			Num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Second number: ");
			Num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Main Menu");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("4. Division");
			Console.WriteLine("Enter the operation you want to perform: ");
			option = Convert.ToChar(Console.ReadLine());
			switch (option)
			{
				case '1':
					result = Num1 + Num2;
					Console.WriteLine("The result of Addition is: ${result}");
					break;

				case '2':
					result = Num1 - Num2;
					Console.WriteLine("The result of Subtraction is: {0}", result);
					break;

				case '3':
					result = Num1 * Num2;
					Console.WriteLine("The result of Multiplication is: {result}");
					break;

				case '4':
					result = Num1 / Num2;
					Console.WriteLine("The result of Division is: {result}");
					break;
			}

			Console.ReadKey();
		}
	}
}