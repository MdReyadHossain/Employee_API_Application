using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Entities
{
    public class Employee
    {
        public ICollection<EmployeeAttendance> EmployeeAttendances { set; get; }
        public Employee()
        {
            EmployeeAttendances = new List<EmployeeAttendance>();
        }

        [Key]
        public int EmployeeId { set; get; }

        [Required]
        public string EmpoyeeName { set; get; }

        [Required]
        public string EmployeeCode { set; get; }

        public double EmployeeSalary { set; get; }

        public int EmployeeSupervisor { set; get; }

        public string Password { set; get; }
    }
}
