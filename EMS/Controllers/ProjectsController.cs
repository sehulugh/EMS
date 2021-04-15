using EMS.Models;
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
        private readonly AppDbContext _db;
        private readonly IConfiguration _config;
        private readonly ILogger _log;
        public ProjectsController(AppDbContext db, IConfiguration config, ILogger<ProjectsController> log)
        {
            _db = db;
            _config = config;
            _log = log;
        }


        public IActionResult Index()
        {
            _log.LogInformation("Starting Index");

            var key = _config["api_key"];
            var smtp = _config["smtp:host"];

            ViewBag.IsAdmin = false;


            var projects = _db.Projects.ToList();

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

            _db.Add(project);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
