using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IEmployeeTaskRepository
    {
        public Task<EmployeeTask> AddTask(EmployeeTask task);
        public Task<List<EmployeeTask>> GetTask();
    }
}
