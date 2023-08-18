using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OfficeDb.Entities
{
    public class EmployeeTask:IEntity
    {
        public int Id { get; set; }
        public string TaskName { get; set; }

        public Employee Employee { get; set; }
    }
}
