using DataAccessLayer.Interfaces;
using DataAccessLayer.Models.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<Employee, int, bool> EmployeeData()
        {
            return new EmployeeRepo();
        }

        public static IRepo<EmployeeAttendance, int, bool> AttendanceData()
        {
            return new AttendanceRepo();
        }

        public static IAttendance<Employee> EmployeeAttendanceData()
        {
            return new AttendanceRepo();
        }

        public static IAuth AuthData()
        {
            return new LoginRepo();
        }

        public static IRepo<Token, int, Token> TokensData()
        {
            return new TokenRepo();
        }
    }
}
