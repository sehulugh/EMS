using EMS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Services
{
    public class DataService : IDataService
    {
        private AppDbContext _db;

        public DataService(AppDbContext db)
        {
            _db = db;
        }

        public List<Project> GetProjects() => _db.Projects.ToList();
        

        public Project SaveProject(ProjectViewModel project)
        {

            var newProject = new Project
            {
                ProjectName = project.ProjectName,
                StartDate = project.StartDate
            };



            if (project.Document != null && project.Document.Length > 0)
            {
                
                string fileName = Path.GetFileName(project.Document.FileName);
                string fileExtension = Path.GetExtension(fileName);

                newProject.FileName = string.Concat(fileName, fileExtension);

                using var stream = new MemoryStream();

                project.Document.CopyTo(stream);

                newProject.ProjectPlan = stream.ToArray();            

            }


            _db.Add(newProject);
            _db.SaveChanges();

            return newProject;
        }
    }
}
