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
    public class EmployeeTaskBusiness:IEmployeeTaskBusiness
    {
        private readonly IEmployeeTaskRepository _repository;
        public EmployeeTaskBusiness(IEmployeeTaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeTask>> GetTask()
        {
            return await _repository.GetTask();
        }
        public async Task<EmployeeTask> AddTask(EmployeeTask task)
        {

            if (task.TaskName.Length > 2)
            {
                return await _repository.AddTask(task);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
