using BooksLib.Services;
using BooksSample.Services;
using BooksSample.ViewModels;
using BooksSample.WPFServices;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BooksSample
{
    public class AppServices
    {
        private AppServices()
        {
            ConfigureServices();
        }

        private static AppServices s_instance;
        public static AppServices Instance
        {
            get => s_instance ?? (s_instance = new AppServices());
        }

        private void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<IDialogService, WPFDialogService>();

            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
