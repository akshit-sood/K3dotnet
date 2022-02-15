using ks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private dbDatabase _db;
        public HomeController(ILogger<HomeController> logger,dbDatabase db)
        {
            _logger = logger;
            _db= db; 
             
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
        [HttpGet]
        public IActionResult working()
        {
            return View();
        }
        [HttpPost]
        public IActionResult workingPost(save data)
        {
            save tbl = new save();
            tbl.Fullname = data.Fullname; 
            tbl.Email = data.Email;
            tbl.Number = data.Number;
            tbl.Radio=  data.Radio;
            _db.Profiles.Add(tbl);
            _db.SaveChanges();
            return  RedirectToAction("Index");
        }

    }
}