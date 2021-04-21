using EMS.Models;
using System;
using System.Collections.Generic;
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
        

        public Project SaveProjext(Project project)
        {
            _db.Add(project);
            _db.SaveChanges();

            return project;
        }
    }
}
