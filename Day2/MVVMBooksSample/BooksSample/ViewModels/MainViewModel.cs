using BooksSample.Models;
using BooksSample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TheBestMVVMFrameworkInTown.Commands;
using TheBestMVVMFrameworkInTown.ViewModels;

namespace BooksSample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IBooksService _booksService;
        public MainViewModel(IBooksService booksService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
         
            RefreshCommand = new DelegateCommand(OnRefresh);
        }
        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
        public IEnumerable<Book> Books => _books;

        private void OnRefresh()
        {
            _books.Clear();
            foreach (var book in _booksService.GetBooks())
            {
                _books.Add(book);
            }
        }

        public DelegateCommand RefreshCommand { get; }
    }
}
