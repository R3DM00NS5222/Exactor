using Exactor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exactor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DatingList()
        {
            return View();
        }

        public IActionResult OpenerList()
        {
            return View();
        }

        public IActionResult NineToFive()
        {
            return View();
        }
        
        public IActionResult ElevenToSeven()
        {
            return View();
        }
        
        public IActionResult CloserJunior()
        {
            return View();
        }
        
        public IActionResult CloserSenior()
        {
            return View();
        }
        
        public IActionResult GravesManager()
        {
            return View();
        }

        public IActionResult Tasks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}