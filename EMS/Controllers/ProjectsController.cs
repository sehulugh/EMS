using EMS.Models;
using EMS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IDataService _ds;
        private readonly IConfiguration _config;
        private readonly ILogger _log;
        public ProjectsController(IDataService ds, IConfiguration config, ILogger<ProjectsController> log)
        {
            _ds = ds;
            _config = config;
            _log = log;
        }


        public IActionResult Index()
        {
            _log.LogInformation("Starting Index");

            var localKey = _config["local_Key"];
            var key = _config["api_key"];
            var smtp = _config["smtp:host"];

            ViewBag.IsAdmin = false;


            var projects = _ds.GetProjects();

            if (projects == null)
            {
                return NotFound();
            }


            return View(projects);
        }

        public IActionResult Create() => View();
        
        [HttpPost]
        public IActionResult Create(Project project)
        {

            _ds.SaveProjext(project);

            return RedirectToAction("Index");
        }
    }
}
