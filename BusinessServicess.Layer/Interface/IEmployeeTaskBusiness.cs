using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServicess.Layer.Interface
{
    public interface IEmployeeTaskBusiness
    {
        public Task<EmployeeTask> AddTask(EmployeeTask task);
        public Task<List<EmployeeTask>> GetTask();
    }
}
