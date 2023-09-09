using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class EmployeeRepo : Repo, IRepo<Employee, int, bool>
    {
        public bool Add(Employee obj)
        {
            var user = (from emp in db.Employees
                        where emp.EmployeeId == obj.EmployeeId
                        select emp).SingleOrDefault();

            if (user == null)
            {
                Login login = new Login
                {
                    EmployeeId = obj.EmployeeId,
                    Password = obj.Password
                };
                try
                {
                    db.Logins.Add(login);
                    db.SaveChanges();

                    db.Employees.Add(obj);
                    return db.SaveChanges() > 0;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            var employee = Get(id);
            db.Employees.Remove(employee);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            var user = db.Employees
                        .OrderByDescending(e => e.EmployeeSalary)
                        .Skip(2)
                        .First();

            var employee = (from emp in db.Employees
                            where emp.EmployeeSalary == user.EmployeeSalary
                            select emp).ToList();

            return employee;
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Update(Employee obj)
        {
            var user = (from emp in db.Employees
                        where emp.EmployeeCode == obj.EmployeeCode && emp.EmployeeId != obj.EmployeeId
                        select emp).FirstOrDefault();

            if (user == null)
            {
                var employee = Get(obj.EmployeeId);
                employee.EmpoyeeName = obj.EmpoyeeName;
                employee.EmployeeCode = obj.EmployeeCode;
                return db.SaveChanges() > 0;
            }

            return false;
        }
    }
}
