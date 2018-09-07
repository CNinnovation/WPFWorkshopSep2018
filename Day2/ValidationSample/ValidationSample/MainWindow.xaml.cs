using System;
using System.Collections.Generic;
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

namespace ValidationSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SomeData _someData = new SomeData { X1 = 2, X2 = 2 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _someData;
        }

        private void OnShow(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"x1: {_someData.X1}, x2: {_someData.X2}, Email: {_someData.Email}");
        }
    }
}
