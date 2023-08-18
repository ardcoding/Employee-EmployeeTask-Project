using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OfficeDb.Entities
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }

        public ICollection<EmployeeTask> EmployeeTasks { get; set; }
    }
}
