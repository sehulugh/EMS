using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Services
{
    public interface IDataService
    {
        List<Project> GetProjects();
        Project SaveProject(ProjectViewModel project);
    }
}
