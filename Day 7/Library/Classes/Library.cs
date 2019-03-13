using System;
using System.Collections.Generic;
using System.Threading;

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

    public class Books
    {
        public List<Book> Romance { get; set; }
        public List<Book> Horror { get; set; }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public int ISBN { get; set; }

        public Book(string name, string author, string type)
        {
            Name = name;
            Author = author;
            Type = type;
        }
    }
}