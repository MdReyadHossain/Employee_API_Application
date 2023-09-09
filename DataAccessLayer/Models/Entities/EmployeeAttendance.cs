using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Entities
{
    public class EmployeeAttendance
    {
        [Key]
        public int AttendanceId { set; get; }

        [ForeignKey("Employee")]
        public int EmployeeId { set; get; }
        public virtual Employee Employee { set; get; }

        [Required]
        public DateTime AttendanceDate { set; get; }

        [Required]
        public bool IsPresent { set; get; }

        [Required]
        public bool IsAbsent { set; get; }

        [Required]
        public bool IsOffday { set; get; }
    }
}
