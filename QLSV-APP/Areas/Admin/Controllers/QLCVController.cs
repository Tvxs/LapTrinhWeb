using Microsoft.AspNetCore.Mvc;
using WEBAPP.Controllers;
using WEBAPP.Models;

namespace QLSV_APP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QLCVController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QLCVController(ApplicationDbContext context)

        {
            _context = context;
        }
        [Route("Admin/[controller]")]
        public IActionResult Index()
        {
            ViewBag.Data = _context.Congviecs.ToList();
            return View();
        }
        [Route("Admin/[controller]/[action]")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Admin/[controller]/[action]")]
        public async Task<IActionResult> CreateData(congviec input)
        {
            if(input == null)
            {
                return null;
            }
            _context.Add(input);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "QLCV", new { area = "Admin" });
        }
        [Route("Admin/[controller]/[action]")]
        public async Task<IActionResult> Edit(int input)
        {
            var congviec = _context.Congviecs.FirstOrDefault(x => x.Id == input);
            return View("Edit",congviec);
        }
        [Route("Admin/[controller]/[action]")]
        public async Task<IActionResult> EditData(congviec input)
        {
            if (input == null)
            {
                return null;
            }
            var congviec = _context.Congviecs.FirstOrDefault(x => x.Id == input.Id);
            if(congviec == null)
            {
                return null;
            }
            congviec.Post = input.Post;
                congviec.CompanyName = input.CompanyName;
            congviec.place = input.place;
            congviec.salaray = input.salaray;
            congviec.jobType = input.jobType;
            congviec.Shift = input.Shift;
            congviec.Quali = input.Quali;
            congviec.jobDetais = input.jobDetais;
            congviec.rating = input.rating;
            _context.Update(congviec);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "QLCV", new { area = "Admin" });
        }
        [Route("Admin/[controller]/[action]")]
        public async Task<IActionResult> Delete(int input)
        {
            var congviec = _context.Congviecs.FirstOrDefault(x => x.Id == input);
            _context.Remove(congviec);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "QLCV", new { area = "Admin" });
        }
    }
  }

