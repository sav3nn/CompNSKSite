using System.Diagnostics;
using System.Linq;
using CompNSKSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CompNSKSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
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
            var products = _context.Product.ToList();
            return View(products); 
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
        public IActionResult Check(Feedback contact)
        {
            if (ModelState.IsValid)
            {
                var feedback = new Feedback
                {
                    Name = contact.Name,
                    Phone_Number = contact.Phone_Number,
                    Email = contact.Email,
                    Message = contact.Message,
                    Submission_Date = DateTime.Now
                };

                _context.Feedback.Add(feedback);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.SuccessMessage = "Ваше сообщение успешно отправлено!";
                return View("Contacts");
            }

            return View("Contacts", contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
