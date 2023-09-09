using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IAttendance<TYPE>
    {
        List<TYPE> GetRegularEmployee();
        IEnumerable<object> GetMonthlyAttendance(int month, int year);
    }
}
