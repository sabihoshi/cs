using System;

namespace Rand
{
	internal class Program
	{
		private static readonly Random r = new Random();

		private static int Rand()
		{
			int n = r.Next();
			return n;
		}

		private static void Main(string[] args)
		{
			Console.WriteLine("Generated numbers are:");
			for (var i = 0; i < 5; i++) Console.WriteLine(Rand());
			Console.ReadKey();
		}
	}
}