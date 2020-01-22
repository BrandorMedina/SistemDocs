using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Controllers
{
    public class DocsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DocCreate()
        {
            return View();
        }
    }
}