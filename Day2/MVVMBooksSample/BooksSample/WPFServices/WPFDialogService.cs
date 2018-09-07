using BooksLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BooksSample.WPFServices
{
    public class WPFDialogService : IDialogService
    {
        public Task ShowDialogAsync(string text)
        {
            MessageBox.Show(text);
            return Task.CompletedTask;
        }
    }
}
