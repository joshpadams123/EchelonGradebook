using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EchelonGradebook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace EchelonGradebook.Controllers
{
    //[Authorize]
    public class SessionController : Controller
    {
        private ILoginRepository repository;
        public SessionController(ILoginRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Login);
        public IActionResult SessionHome()
        {
            //ViewData["user"] = HttpContext.Session.GetString("User");
            ViewData["user"] = HttpContext.Session.IsAvailable.ToString();
            return View();
        }

        public IActionResult Courses()
        {
            ViewData["user"] = HttpContext.Session.GetString("User");
            //ViewData["user"] = HttpContext.Session.IsAvailable.ToString();
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("User");
            return View("Login");
        }

        [AllowAnonymous]
        [HttpPost]
        public ViewResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("User", login.username);
                ViewData["user"] = HttpContext.Session.GetString("User");
                //ViewData["user"] = HttpContext.Session.IsAvailable.ToString();
                return View("SessionHome", login);
            }
            else
            {
                return View();
            }
        }
    }
    
}
