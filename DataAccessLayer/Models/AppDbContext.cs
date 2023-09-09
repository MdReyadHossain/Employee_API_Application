using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Login> Logins { set; get; }
        public DbSet<Token> Tokens { set; get; }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<EmployeeAttendance> EmployeeAttendances { set; get; }
    }
}
