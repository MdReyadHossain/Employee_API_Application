using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Entities
{
    public class Login
    {
        [Key]
        public int EmployeeId { set; get; }
        
        public string Password { set; get; }
    }
}
