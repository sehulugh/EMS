using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Name Required")]
        [Display(Name ="Name")]
        public string EmployeeName { get; set; }


        [Display(Name ="Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int Age
        {
            get => DateTime.Now.Year - DOB.Year;
        }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
