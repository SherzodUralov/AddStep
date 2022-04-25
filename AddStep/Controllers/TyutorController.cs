using AddStep.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Controllers
{
    public class TyutorController : Controller
    {
        private readonly ITyutorRepository repository;

        public TyutorController(ITyutorRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var model = repository.GetByAll();
            return View(model);
        }
    }
}
