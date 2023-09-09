using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EmployeeService
    {        
        public static List<EmployeeDTO> Get()
        {
            var data = DataAccessFactory.EmployeeData().Get();
            var map = MapperService<Employee, EmployeeDTO>.GetMapper();
            return map.Map<List<EmployeeDTO>>(data);
        }

        public static EmployeeDTO Get(int id)
        {
            var data = DataAccessFactory.EmployeeData().Get(id);
            var map = MapperService<Employee, EmployeeDTO>.GetMapper();
            return map.Map<EmployeeDTO>(data);
        }

        public static bool Add(EmployeeDTO emp)
        {
            var mapper = MapperService<EmployeeDTO, Employee>.GetMapper();
            var map = mapper.Map<Employee>(emp);
            return DataAccessFactory.EmployeeData().Add(map);
        }

        public static bool Update(EmployeeDTO emp)
        {
            var mapper = MapperService<EmployeeDTO, Employee>.GetMapper();
            var map = mapper.Map<Employee>(emp);
            return DataAccessFactory.EmployeeData().Update(map);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployeeData().Delete(id);
        }
    }
}
