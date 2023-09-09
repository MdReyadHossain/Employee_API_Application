using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class Repo
    {
        internal AppDbContext db;
        internal Repo()
        {
            db = new AppDbContext();
        }
    }
}
