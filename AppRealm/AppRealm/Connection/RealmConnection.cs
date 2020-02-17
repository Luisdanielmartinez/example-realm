using Realms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppRealm.Connection
{
   public static class RealmConnection
    {
        public static Realm getConnection()
        {
            Realm r = null;
            try
            {
                var con = new RealmConfiguration("myappDb.realm");
                System.Diagnostics.Debug.WriteLine(con.DatabasePath);
                 r = Realm.GetInstance(con);
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error",$"este es el error{ex.Message}","Ok");
            }
            return r;

        }
    }
}
