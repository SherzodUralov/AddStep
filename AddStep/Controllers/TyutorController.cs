using AddStep.Models;
using AddStep.Models.Repository;
using AddStep.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Controllers
{
    public class TyutorController : Controller
    {
        private readonly ITyutorRepository repository;
        private readonly IWebHostEnvironment webHost;

        public TyutorController(ITyutorRepository repository, IWebHostEnvironment webHost)
        {
            this.repository = repository;
            this.webHost = webHost;
        }
        public IActionResult Index(string SearchText)
        {
           
            var model = repository.GetByAll(SearchText);
            return View(model);
            
        }
        [HttpGet]
        public ViewResult Create() 
        
        {
            var x = repository.GetRegions();
            ViewData["region"] = new SelectList(x, "Id", "RegionName");
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(TyutorCreateViewModel tyutor)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcsesUploded(tyutor);
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
                    DistrictId = tyutor.DistrictId,
                    PhotoFilePath = uniqueFileName,
                    Passport = tyutor.Passport
                };
                newtyutor = repository.Create(newtyutor);
                return RedirectToAction("Index");
            }
            return View();
        }

        private string ProcsesUploded(TyutorCreateViewModel tyutor)
        {
            string uniqueFileName = string.Empty;
            if (tyutor.Photo != null)
            {
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + tyutor.Photo.FileName;
                string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
                tyutor.Photo.CopyTo(new FileStream(imageFilePath, FileMode.Create));
            }

            return uniqueFileName;
        }

        [HttpPost]
        public IActionResult GetDistrict(int regionId)
        {
            var district = repository.GetDistricts(regionId);
            return Ok(district.ToArray());
        }
        [HttpGet]
        public ViewResult Edit(int id) 
        {
            var x = repository.GetRegions();
            ViewData["region"] = new SelectList(x, "Id", "RegionName");
            var tyutor = repository.GetById(id);
                TyutorEditViewModel viewModel = new TyutorEditViewModel
            {
                Id = tyutor.TyutorId,
                Name = tyutor.FirstName,
                LastName = tyutor.LastName,
                SureName = tyutor.SureName,
                Birthday = tyutor.Birthday,
                Internship = tyutor.Staj,
                MobileNamber = tyutor.MobileNamber,
                Gender = tyutor.Gender,
                RegionId = tyutor.RegionId,
                DistrictId = tyutor.DistrictId,
                ExsistingPhotoFilePath = tyutor.PhotoFilePath,
                Passport = tyutor.Passport
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(TyutorEditViewModel tyutor)
        {
            Tyutor exitnigTyutor = repository.GetById(tyutor.Id);

            exitnigTyutor.FirstName = tyutor.Name;
            exitnigTyutor.LastName = tyutor.LastName;
            exitnigTyutor.SureName = tyutor.SureName;
            exitnigTyutor.Birthday = tyutor.Birthday;
            exitnigTyutor.Staj = tyutor.Internship;
            exitnigTyutor.MobileNamber = tyutor.MobileNamber;
            exitnigTyutor.Passport = tyutor.Passport;
            exitnigTyutor.Gender = tyutor.Gender;
            exitnigTyutor.RegionId = tyutor.RegionId;
            exitnigTyutor.DistrictId = tyutor.DistrictId;
            if (tyutor.Photo != null)
            {
                if (tyutor.ExsistingPhotoFilePath != null)
                {
                    string filepath = Path.Combine(webHost.WebRootPath, "images", tyutor.ExsistingPhotoFilePath);
                    System.IO.File.Delete(filepath);
                }
                exitnigTyutor.PhotoFilePath = ProcsesUploded(tyutor);
            }

            repository.Update(exitnigTyutor);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id) 
        {
            var tyutor = repository.GetById(id);
            if (tyutor.PhotoFilePath != null)
            {
                string filepath = Path.Combine(webHost.WebRootPath, "images", tyutor.PhotoFilePath);
                System.IO.File.Delete(filepath);
            }
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
