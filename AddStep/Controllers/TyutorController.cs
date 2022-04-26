using AddStep.Models;
using AddStep.Models.Repository;
using AddStep.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [HttpGet]
        public ViewResult Create() 
        
        {
            var x = repository.GetRegions();
            ViewData["region"] = new SelectList(x, "Id", "RegionName");
            var y = repository.GetDistricts();
            ViewData["dist"] = new SelectList(y, "Id", "DistrictName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(TyutorCreateViewModel tyutor)
        {
            Tyutor newtyutor = new Tyutor
            {
                FirstName = tyutor.Name,
                LastName = tyutor.LastName,
                SureName = tyutor.SureName,
                Birthday = tyutor.Birthday,
                Staj = tyutor.Internship,
                MobileNamber = tyutor.MobileNamber,
                Gender = tyutor.Gender,
                RegionId = tyutor.RegionId,
                DistrictId = tyutor.DistrictId
            };
            newtyutor = repository.Create(newtyutor);
            return RedirectToAction("Index");
        }
    }
}
