using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int PeojectId { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
