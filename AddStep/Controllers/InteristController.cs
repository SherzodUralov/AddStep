using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Controllers
{
    public class InteristController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
