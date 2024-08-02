using Microsoft.AspNetCore.Mvc;
using Reza_Abbasinasl_HW14.Models;
using Reza_Abbasinasl_HW14.Validation;
using System.Diagnostics;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;

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
            bool firstName = model.FirstName.ValidationNameAndFamily();
            bool LastName = model.FirstName.ValidationNameAndFamily();
            bool phoneNumber = model.PhoneNumber.ValidationPhoneNumber();
            bool birthDay = model.BirthDay.ValidationPermissibleAge();
            bool courseCode = model.CourseCode.ValidationCourseCode();
            bool genderCzheck = model.GenderCzheck.ValidationGenderCzheck();
            bool checkRules = model.CheckRules.ValidationCheckRules();

            if (firstName && LastName && phoneNumber && birthDay && courseCode && genderCzheck && checkRules)
            {
                ViewData["success"] = "Ok";
                string FilePath = "Book.txt";
                var json = JsonConvert.SerializeObject(model);
                System.IO.File.WriteAllText(FilePath, json);
                return RedirectToAction("Subscription");
            }
            ViewData["error"] = "No";
            return View("Subscription");
        }
        public IActionResult Rules()
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
