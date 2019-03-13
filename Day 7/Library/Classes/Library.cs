using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Classes
{
    public static class Extensions
    {
        public static bool CaseInsensitiveContains(this string text, string value,
            StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }
    }

    public class Lib
    {
        public Lib(List<Book> books)
        {
            Books = books;
        }

        public List<Book> Books { get; set; } = new List<Book>();
    }

    public class Book
    {
        public Book(string name, string author, string type, List<string> genre)
        {
            Name = name;
            Author = author;
            Type = type;
            Genre = genre.ToList();
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public List<string> Genre { get; set; }
    }
}