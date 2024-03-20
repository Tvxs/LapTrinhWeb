using Microsoft.AspNetCore.Mvc;
using WEBAPP.Models;
using System.Diagnostics;

namespace WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Data = _context.Congviecs.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}