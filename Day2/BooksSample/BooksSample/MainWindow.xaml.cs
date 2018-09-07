using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // private Book _book;
        private IEnumerable<Book> _books;
        private ICollectionView _booksView;
      //  public Book CurrentBook { get; set; }
        public MainWindow()
        {
            _books = new BooksFactory().GetBooks();
       
            this.DataContext = _books;

            _booksView = CollectionViewSource.GetDefaultView(_books);

            _booksView.Filter = o => (o as Book).Publisher == "Wrox Press";
            //{
            //    Book b = o as Book;
            //    return b.Publisher == "Wrox Press";
            //};
            InitializeComponent();


        }

        private void OnShowCurrent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((_booksView.CurrentItem as Book).Title);
          //   MessageBox.Show(CurrentBook.Title);
        }

        private void OnChange(object sender, RoutedEventArgs e)
        {
            (_booksView.CurrentItem as Book).Title = "Professional C# 9";
        }
    }
}
