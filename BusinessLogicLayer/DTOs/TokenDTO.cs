using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class TokenDTO
    {
        public int Id { get; set; }

        public string TokenKey { get; set; }

        public string EmployeeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ExpiredAt { get; set; }
    }
}
