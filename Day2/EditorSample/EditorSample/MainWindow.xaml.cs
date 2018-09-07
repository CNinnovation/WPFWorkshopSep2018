using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EditorSample
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

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                string text = File.ReadAllText(filename);
                theText.Text = text;
            }
        }

        private void OnExit(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void OnAction1(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Action 1");
        }

        private void OnCanExecuteAction1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }
    }
}
