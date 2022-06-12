using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace DataAccess.Access
{
    public class dalLogin
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public bool GetLogin(Login _login)
        {
            var querry = from login in db.Logins
                         where login.Username == _login.Username
                         && login.Password == _login.Password
                         select login;

            if (querry.Any())
                return true;
            return false;
        }
    }
}
