using System.Collections.Generic;

namespace Library.Classes
{
	internal class bokkeh
	{
		public class Rootobject
		{
			public List<Book> Books { get; set; }
		}

		public class Book
		{
			public string Name { get; set; }
			public string Author { get; set; }
			public string Type { get; set; }
			public string[] Genre { get; set; }
		}
	}
}