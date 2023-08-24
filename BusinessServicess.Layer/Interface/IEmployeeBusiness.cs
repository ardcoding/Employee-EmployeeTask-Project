using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServicess.Layer.Interface
{
    public interface IEmployeeBusiness
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<List<Employee>> GetEmployee();
    }
}
