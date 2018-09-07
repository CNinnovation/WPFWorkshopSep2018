using System.Collections.Generic;
using BooksSample.Models;

namespace BooksSample.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
    }
}