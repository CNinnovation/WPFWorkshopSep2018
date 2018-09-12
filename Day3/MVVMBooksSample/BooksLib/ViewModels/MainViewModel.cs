using BooksLib.Services;
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
        private readonly IDialogService _dialogService;
        private readonly IBooksStateService _booksStateService;
        public MainViewModel(IBooksService booksService, IDialogService dialogService, IBooksStateService booksStateService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
            _booksStateService = booksStateService ?? throw new ArgumentNullException(nameof(booksStateService));
         
            RefreshCommand = new DelegateCommand(OnRefresh);
            ShowDialogCommand = new DelegateCommand(OnShowDialog);
        }

        private async void OnShowDialog()
        {
            await _dialogService.ShowDialogAsync("hello from the view-model");
        }

        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
        public IEnumerable<Book> Books => _books;

        public Book SelectedBook
        {
            get => _booksStateService.SelectedBook;
            set => _booksStateService.SelectedBook = value;
        }

        private void OnRefresh()
        {
            _books.Clear();
            foreach (var book in _booksService.GetBooks())
            {
                _books.Add(book);
            }
        }

        public DelegateCommand RefreshCommand { get; }

        public DelegateCommand ShowDialogCommand { get; }
    }
}
