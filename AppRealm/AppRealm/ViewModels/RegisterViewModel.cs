using AppRealm.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppRealm.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
        private User user;
         public string UserName { get; set; }
         public string Name { get; set; }
        public string Password { get; set; }

        public ICommand SaveCommand => new RelayCommand(saveData);
        public ICommand CancelCommand => new RelayCommand(Cancel);
        public RegisterViewModel()
        {
           
        }

        private async void saveData()
        {
            user = new User { 
                UserName = this.UserName,
                Name = this.Name,
                Password=this.Password
            }; 

            var response = await DataStoreUser.AddItemAsync(user);
            if (!response)
            {
              await  App.Current.MainPage.DisplayAlert("Error","Error al insertar los datos","ok");
                return;
            }
            await App.Current.MainPage.DisplayAlert("Info", "Se insertaron los datos correctamente", "ok");
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
        private async void Cancel()
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        } 
    }
}
