using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AttendanceService
    {
        public static List<EmployeeAttendanceDTO> Get()
        {
            var data = DataAccessFactory.AttendanceData().Get();
            var map = MapperService<EmployeeAttendance, EmployeeAttendanceDTO>.GetMapper();
            return map.Map<List<EmployeeAttendanceDTO>>(data);
        }

        public static EmployeeAttendanceDTO Get(int id)
        {
            var data = DataAccessFactory.AttendanceData().Get(id);
            var map = MapperService<EmployeeAttendance, EmployeeAttendanceDTO>.GetMapper();
            return map.Map<EmployeeAttendanceDTO>(data);
        }

        public static List<EmployeeDTO> GetRegularEmployee()
        {
            var data = DataAccessFactory.EmployeeAttendanceData().GetRegularEmployee();
            var map = MapperService<Employee, EmployeeDTO>.GetMapper();
            return map.Map<List<EmployeeDTO>>(data);
        }

        public static IEnumerable<object> GetMonthlyReport(int month, int year)
        {
            var data = DataAccessFactory.EmployeeAttendanceData().GetMonthlyAttendance(month, year);
            return data;
        }

        public static bool Add(EmployeeAttendanceDTO emp)
        {
            var mapper = MapperService<EmployeeAttendanceDTO, EmployeeAttendance>.GetMapper();
            var map = mapper.Map<EmployeeAttendance>(emp);
            return DataAccessFactory.AttendanceData().Add(map);
        }

        public static bool Update(EmployeeAttendanceDTO attendance)
        {
            var mapper = MapperService<EmployeeAttendanceDTO, EmployeeAttendance>.GetMapper();
            var map = mapper.Map<EmployeeAttendance>(attendance);
            return DataAccessFactory.AttendanceData().Update(map);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AttendanceData().Delete(id);
        }
    }
}
