using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Entities
{
    public class Token
    {
        public int Id { get; set; }

        public string TokenKey { get; set; }

        [ForeignKey("Login")]
        public int EmployeeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ExpiredAt { get; set; }

        public virtual Login Login { get; set; }
    }
}
