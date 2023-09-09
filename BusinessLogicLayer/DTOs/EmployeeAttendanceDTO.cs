using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class EmployeeAttendanceDTO
    {
        public int AttendanceId { set; get; }

        [Required]
        public int EmployeeId { set; get; }

        [Required(ErrorMessage = "Attendance date should not be empty!")]
        public DateTime AttendanceDate { set; get; }

        [Required]
        public bool IsPresent { set; get; }

        [Required]
        public bool IsAbsent { set; get; }

        [Required]
        public bool IsOffday { set; get; }
    }
}
