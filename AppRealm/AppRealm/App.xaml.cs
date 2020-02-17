using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppRealm.Services;
using AppRealm.Views;

namespace AppRealm
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<UserRepo>();
            // MainPage = new AppShell();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
