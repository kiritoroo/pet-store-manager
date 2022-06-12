using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using DataAccess.Access;

namespace Business.Manager
{
    public class bllLogin
    {
        dalLogin dal = new dalLogin();

        public bool GetLogin(Login _login)
        {
            return this.dal.GetLogin(_login);
        }
    }
}
