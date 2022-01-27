using eNno.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eNno.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeamController : Controller
    {
        private readonly DataContext _context;

        public TeamController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid) return View();
            _context.Teams.Add(team);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
