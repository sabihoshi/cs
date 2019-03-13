using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Books
    {
        public List<Book> Romance { get; set; }
        public List<Book> Horror { get; set; }
    }

    public class Book
    {
        protected static int Id = 0;
        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public int ISBN { get; set; }

        public Book(string name, string author, string type)
        {
            ISBN = Interlocked.Increment(ref Id);
            Name = name;
            Author = author;
            Type = type;
        }
    }
}