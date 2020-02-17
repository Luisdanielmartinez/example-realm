using AppRealm.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppRealm.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(validaterLogin);
        public ICommand RegisterCommand => new RelayCommand(goToRegister);

        public LoginViewModel()
        {

        }

        public async  void validaterLogin()
        {
            var user = await DataStoreUser.GetUserByUserName(UserName,Password);
            if (user==null)
            {
               await App.Current.MainPage.DisplayAlert("Info","Usuario o Contraseña estan incorrectas","ok");
                return;
            }

            App.Current.MainPage=new AppShell();
        }

        public async void goToRegister()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RegisterPage()));
        }
    }
}
