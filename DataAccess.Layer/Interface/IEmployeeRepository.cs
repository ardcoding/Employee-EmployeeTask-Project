using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<List<Employee>> GetEmployee();
    }
}
