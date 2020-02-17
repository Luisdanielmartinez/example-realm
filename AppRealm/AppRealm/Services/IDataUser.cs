using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppRealm.Services
{
    public interface IDataUser<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetUserByUserName(string userName, string password);
    }
}
