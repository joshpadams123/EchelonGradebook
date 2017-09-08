using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EchelonGradebook.Models;
using Microsoft.AspNetCore.Http;

namespace EchelonGradebook.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult SessionHome(Login login)
        {
            //HttpContext.Session.GetString(login.Username);
            
            //ViewData["user"] = HttpContext.Session.GetString(login.Username);
            return View();
        }

        public IActionResult Courses(Login login)
        {
            //HttpContext.Session.GetString(login.Username);

            //ViewData["user"] = HttpContext.Session.GetString(login.Username);
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
                return View("SessionHome", login);
            }
            else
            {
                return View();
            }
        }
    }
}
