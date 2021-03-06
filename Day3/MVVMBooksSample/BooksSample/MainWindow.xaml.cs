﻿using BooksSample.Models;
using BooksSample.Services;
using BooksSample.ViewModels;
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
using Microsoft.Extensions.DependencyInjection;
using BooksLib.ViewModels;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            ViewModel = AppServices.Instance.Container.GetService<MainViewModel>();
            DetailViewModel = AppServices.Instance.Container.GetService<BookDetailViewModel>();

            this.DataContext = this;

            InitializeComponent();
        }

        public MainViewModel ViewModel { get;  }
        public BookDetailViewModel DetailViewModel { get;  }
    }
}
