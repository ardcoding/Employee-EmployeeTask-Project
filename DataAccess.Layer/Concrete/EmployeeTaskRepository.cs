using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Concrete
{
    public class EmployeeTaskRepository:IEmployeeTaskRepository
    {
        private readonly OfficeDbContext _dbcontext;

        public EmployeeTaskRepository(OfficeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<EmployeeTask> AddTask(EmployeeTask task)
        {
            _dbcontext.EmployeeTasks.Add(task);
            await _dbcontext.SaveChangesAsync();
            return task;
        }

        public async Task<List<EmployeeTask>> GetTask()
        {
            return await _dbcontext.EmployeeTasks.Include(e => e.Employee).ToListAsync();
        }
    }
}
