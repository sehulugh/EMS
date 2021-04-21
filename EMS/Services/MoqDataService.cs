using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Services
{
    public class MoqDataService : IDataService
    {
        private List<Project> _projs;
        public MoqDataService()
        {
            _projs = new List<Project>
            {
                new Project{ProjectID = 1, ProjectName = "Dashboard", StartDate = DateTime.Now},
                new Project{ProjectID = 1, ProjectName = "DataWare house", StartDate = DateTime.Now}
            };
        }

        public List<Project> GetProjects() => _projs;
       

        public Project SaveProjext(Project project)
        {
            project.ProjectID = _projs.Max(m => m.ProjectID) + 1;
            _projs.Add(project);

            return project;
        }
    }
}
