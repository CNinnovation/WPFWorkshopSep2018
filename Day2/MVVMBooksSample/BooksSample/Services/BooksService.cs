using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Services
{
    public class BooksService : IBooksService
    {
        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                 new Book { BookdId = 1, Isbn = "3488934", Title = "Professional C# 6", Publisher = "Wrox Press", Authors = new string[] { "Christian Nagel" } },
                 new Book { BookdId = 2, Isbn = "74575", Title = "Professional C# 7", Publisher = "Wrox Press", Authors = new string[] { "Christian Nagel" } },
                 new Book { BookdId = 3, Isbn = "3488934", Title = "Enterprise Services", Publisher = "Addison Wesley", Authors = new string[] { "Christian Nagel" } },
                 new Book { BookdId = 4, Isbn = "347834773", Title = "Beginning Visual C# 2010", Publisher = "Wrox Press", Authors = new string[] { "Karli Watson", "Christian Nagel"}}
            };

    }
}
