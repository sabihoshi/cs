using System.Collections.Generic;

namespace Library.Classes
{
	public class Bor
	{
		public List<Borrower> Borrowers { get; set; } = new List<Borrower>();
	}

	public class Borrower
	{
		public Borrower(string book, string name, string borrowed, string expiry)
		{
			Name = name;
			Book = book;
			Borrowed = borrowed;
			Expiry = expiry;
		}

		public string Name { get; set; }
		public string Book { get; set; }
		public string Borrowed { get; set; }
		public string Expiry { get; set; }
	}
}