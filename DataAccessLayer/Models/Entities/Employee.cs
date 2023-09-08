using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Name should not be empty!")]
        public string EmpoyeeName { set; get; }

        [Required(ErrorMessage = "Employee code should not be empty!")]
        [MinLength(4)]
        public string EmployeeCode { set; get; }

        [Required(ErrorMessage = "Enter an amount of salary!")]
        public double EmployeeSalary { set; get; }

        [Required]
        public int EmployeeSupervisor { set; get; }
    }
}
