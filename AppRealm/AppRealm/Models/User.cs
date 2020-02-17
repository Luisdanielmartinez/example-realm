using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRealm.Models
{
   public class User : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
