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

namespace Lab_2_real
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonOneClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click in Button one but not Parent");
            e.Handled = true;
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click in Parent");
        }

        private void OnButtonTwoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click in Button two and in Parent");
        }


        private void OnButtonOneClick_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dont Show this since its handled already");
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
