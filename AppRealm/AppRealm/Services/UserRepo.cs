using AppRealm.Connection;
using AppRealm.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRealm.Services
{
    public class UserRepo : IDataUser<User>
    {
      
        private Realm db;
        public UserRepo()
        {
            db = RealmConnection.getConnection();
        }


        public async Task<bool> AddItemAsync(User item)
        {
            if (item==null)
            {
               return await Task.FromResult(false);
            }

            db.Write(() =>
            {
                db.Add(item);
            });
        
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var user = db.Find<User>(id);
            db.Remove(user);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(User item)
        {
            var user = db.Find<User>(item.Id);
            db.Remove(user);
            db.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<User> GetUserByUserName(string username,string password)
        {
            var myPuppy = db.All<User>().First(u => u.UserName == username && u.Password==password);
            return await Task.FromResult(myPuppy);
        }

    }
}
