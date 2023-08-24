using BusinessServicess.Layer.Interface;
using DataAccess.Layer.Interface;
using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServicess.Layer.Concrete
{
    public class EmployeeBusiness: IEmployeeBusiness
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeBusiness(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await _repository.GetEmployee();
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {

            if (employee.EmployeeName.Length > 2)
            {
                return await _repository.AddEmployee(employee);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
