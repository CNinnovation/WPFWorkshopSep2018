using BooksSample.Models;
using System.ComponentModel;

namespace BooksLib.Services
{
    public interface IBooksStateService : INotifyPropertyChanged
    {
        Book SelectedBook { get; set; }
    }
}