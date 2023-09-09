using DataAccessLayer.Interfaces;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class AttendanceRepo : Repo, IRepo<EmployeeAttendance, int, bool>, IAttendance<Employee>
    {
        public bool Add(EmployeeAttendance obj)
        {
            db.EmployeeAttendances.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var attendance = Get(id);
            db.EmployeeAttendances.Remove(attendance);
            return db.SaveChanges() > 0;
        }

        public List<EmployeeAttendance> Get()
        {
            return db.EmployeeAttendances.ToList();
        }

        public EmployeeAttendance Get(int id)
        {
            return db.EmployeeAttendances.Find(id);
        }

        public bool Update(EmployeeAttendance obj)
        {
            var attendance = Get(obj.AttendanceId);
            db.Entry(attendance).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public List<Employee> GetRegularEmployee()
        {
            var employee = db.Employees
                          .Where(emp => !db.EmployeeAttendances.Any(att => att.EmployeeId == emp.EmployeeId && att.IsAbsent))
                          .OrderByDescending(emp => emp.EmployeeSalary)
                          .Select(emp => emp)
                          .ToList();

            return employee;
        }

        public IEnumerable<object> GetMonthlyAttendance(int month, int year)
        {
            var monthlyReport = from emp in db.Employees
                                join attend in db.EmployeeAttendances
                                on emp.EmployeeId equals attend.EmployeeId
                                where attend.AttendanceDate.Year == year && attend.AttendanceDate.Month == month
                                group attend by new { emp.EmpoyeeName, emp.EmployeeSalary, attend.AttendanceDate } into reportGroup
                                select new
                                {
                                    EmployeeName = reportGroup.Key.EmpoyeeName,
                                    MonthName = reportGroup.Key.AttendanceDate,
                                    PayableSalary = reportGroup.Key.EmployeeSalary,
                                    TotalPresent = reportGroup.Count(a => a.IsPresent),
                                    TotalAbsent = reportGroup.Count(a => a.IsAbsent),
                                    TotalOffday = reportGroup.Count(a => a.IsOffday)
                                };

            return monthlyReport;
        }
    }
}
