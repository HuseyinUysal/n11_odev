using n11_odev.Services;
using n11_odev.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace n11_odev
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
