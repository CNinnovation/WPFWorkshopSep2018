using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class BooksFactory
    {
        public Book GetTheBook() => new Book { BookdId = 1, Isbn = "3488934", Title = "Professional C# 8", Publisher = "Wrox Press", Authors = new string[] { "Christian Nagel" } };

    }
}
