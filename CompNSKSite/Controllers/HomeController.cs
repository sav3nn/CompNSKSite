using System.Diagnostics;
using CompNSKSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompNSKSite.Controllers
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

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Adress()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Contacts");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
