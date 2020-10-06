using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab16._1_ClientSideValidation.Models;

namespace lab16._1_ClientSideValidation.Controllers
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

        public IActionResult UserInput()
        { 

            return View();
        }

        public IActionResult confirmationPage(string firstname, string lastname, string email, string password)
        {
            return Content($"Thank you for registering!" +
                $"First Name: {firstname} " +
                $"Last Name: {lastname} " +
                $"Email: {email} " +
                $"Password: {password}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
