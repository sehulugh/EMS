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
       

        public Project SaveProject(ProjectViewModel project)
        {
            project.ProjectID = _projs.Max(m => m.ProjectID) + 1;

            var newProject = new Project
            {
                ProjectName = project.ProjectName,
                StartDate = project.StartDate
            };

            _projs.Add(newProject);

            return newProject;
        }
    }
}
