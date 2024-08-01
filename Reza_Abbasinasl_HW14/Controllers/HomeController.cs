using Microsoft.AspNetCore.Mvc;
using Reza_Abbasinasl_HW14.Models;
using Reza_Abbasinasl_HW14.Validation;
using System.Diagnostics;

namespace Reza_Abbasinasl_HW14.Controllers
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
        [HttpGet]
        public IActionResult Subscription()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(SubscriptionViewModel model)
        {
            if (model.CheckRules.ValidationCheckRules())
            {
                ViewData["success"] = "Ok";
                return View("Subscription");
            }
            ViewData["error"] = "No";
            return View("Subscription");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
