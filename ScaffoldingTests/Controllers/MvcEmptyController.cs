using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ScaffoldingTests.Controllers
{
    public class MvcEmptyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}