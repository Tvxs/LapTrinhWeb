using Microsoft.AspNetCore.Mvc;

namespace FN_Gaming.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AcountController : Controller
    {
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Admin")]
        public IActionResult Login()
        {
            return View();
        }
    }
}

