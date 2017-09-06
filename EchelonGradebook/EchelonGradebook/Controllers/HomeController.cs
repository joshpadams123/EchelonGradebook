using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EchelonGradebook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Our gradebook.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact us.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
