using BooksLib.Services;
using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TheBestMVVMFrameworkInTown.Commands;
using TheBestMVVMFrameworkInTown.ViewModels;

namespace BooksLib.ViewModels
{
    public class BookDetailViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;
        private readonly IBooksStateService _booksStateService;
        public BookDetailViewModel(IDialogService dialogService, IBooksStateService booksStateService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
            _booksStateService = booksStateService;
            _booksStateService.PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == "SelectedBook")
                    {
                        Book = _booksStateService.SelectedBook;
                    }
                };

            Action1Command = new DelegateCommand(OnAction1);
        }

        private Book _book;
        public Book Book
        {
            get => _book;
            set => SetProperty(ref _book, value);
        }

        public DelegateCommand Action1Command { get; }

        private async void OnAction1()
        {
            await _dialogService.ShowDialogAsync("in the detail view-model");
        }
    }
}
