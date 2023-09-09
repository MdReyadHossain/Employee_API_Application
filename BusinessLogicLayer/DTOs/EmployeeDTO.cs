using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { set; get; }

        [Required(ErrorMessage = "Name should not be empty!")]
        public string EmpoyeeName { set; get; }

        [Required(ErrorMessage = "Employee code should not be empty!")]
        [MinLength(4)]
        public string EmployeeCode { set; get; }

        [Required(ErrorMessage = "Enter an amount of salary!")]
        public double EmployeeSalary { set; get; }

        public int EmployeeSupervisor { set; get; }

        [Required(ErrorMessage = "Enter a password for your Security")]
        [MinLength(6)]
        public string Password { set; get; }
    }
}
