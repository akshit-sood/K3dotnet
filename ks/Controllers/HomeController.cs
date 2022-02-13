using ks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ks.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contactus()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult signupcshtml()
        {
            return View();
        }
        public IActionResult student()
        {
            return View();
        }
        public IActionResult test()
        {
            return View();
        }
        public IActionResult working()
        {
            return View();
        }

    }
}