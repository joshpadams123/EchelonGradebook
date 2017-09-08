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
        public IActionResult Home()
        {
            return View();
        }


    }
}
