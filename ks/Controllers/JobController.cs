using Microsoft.AspNetCore.Mvc;

namespace ks.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
