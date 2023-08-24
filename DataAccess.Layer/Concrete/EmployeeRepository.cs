using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly OfficeDbContext _dbcontext;

        public EmployeeRepository(OfficeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _dbcontext.Employees.Add(employee);
            await _dbcontext.SaveChangesAsync();
            return employee;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await _dbcontext.Employees.Include(e => e.EmployeeTasks).ToListAsync();

        }
    }
}
