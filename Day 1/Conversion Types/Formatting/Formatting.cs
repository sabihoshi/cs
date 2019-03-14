using System;

namespace Conversion_Types
{
	internal class Formatting
	{
		private static void Main(string[] args)
		{
			var value1 = "Dot";
			var value2 = "Net";
			var value3 = "Sample";
			var sum = 123.56789;
			Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
			Console.WriteLine("{0:0.00}", sum);
			Console.ReadKey();
		}
	}
}