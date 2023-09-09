using DataAccessLayer.Interfaces;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class LoginRepo : Repo, IAuth
    {
        public Login Authenticate(string id, string pass)
        {
            var user = from u in db.Logins
                       where u.EmployeeId.Equals(id)
                       && u.Password.Equals(pass)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;
        }
    }
}
