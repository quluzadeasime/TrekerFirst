using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TREKER.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Destinations()
        {
            return View();
        }
    }
}
