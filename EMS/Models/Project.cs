using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
   
        public string ProjectName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
