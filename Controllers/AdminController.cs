using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Userregister()
        {
            return View();
        }
        public IActionResult Useredit()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }
    }
}