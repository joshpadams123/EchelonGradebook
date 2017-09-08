using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EchelonGradebook.Models;
using Microsoft.AspNetCore.Http;

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

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString(login.Username, login.Username);
                ViewData["user"] = HttpContext.Session.GetString(login.Username);
                return View("Home", login);
            }
            else
            {
                return View();
            }
        }
    }
}
