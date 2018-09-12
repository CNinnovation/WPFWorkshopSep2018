using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TheBestMVVMFrameworkInTown.Core;

namespace BooksLib.Services
{
    public class BooksStateService : BindableBase, IBooksStateService
    {
        public BooksStateService()
        {

        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }
    }
}
