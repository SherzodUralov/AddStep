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
    public class StudentController : Controller
    {
        private readonly IStudentRepository repository;
        private readonly IWebHostEnvironment webHost;

        public StudentController(IStudentRepository repository,IWebHostEnvironment webHost)
        {
            this.repository = repository;
            this.webHost = webHost;
        }
        public IActionResult Index(string Searchtext)
        {
            var model = repository.GetAll(Searchtext);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var x = repository.GetInterists();
            ViewData["interist"] = new SelectList(x, "Id", "Name");
            var y = repository.GetRegions();
            ViewData["region"] = new SelectList(y, "Id", "RegionName");
            var z = repository.GetFaculties();
            ViewData["faculty"] = new SelectList(z, "Id", "FacultyName");
            return View();
        }
        [HttpPost]
        public IActionResult GetDistrict(int regionid) 
        {
            var district = repository.GetDistricts(regionid);
            return Ok(district.ToArray());
        }
        [HttpPost]
        public IActionResult GetInteristType(int interistid)
        {
            var interist = repository.GetInteristTypes(interistid);
            return Ok(interist.ToArray());
        }
        [HttpPost]
        public IActionResult GetBranch(int facultyid)
        {
            var branch = repository.GetBranches(facultyid);
            return Ok(branch.ToArray());
        }
        [HttpPost]
        public IActionResult GetGroup(int branchid)
        {
            var branch = repository.GetGroups(branchid);
            return Ok(branch.ToArray());
        }
        [HttpPost]
        public IActionResult Create(StudentCreateViewModel student)
        {
            string uniqueFileName = ProcsessUploudFile(student);
            Student NewStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                SureName = student.SureName,
                Birthday = student.Birthday,
                Passport = student.Passport,
                Gender = student.Gender,
                MobileNamber = student.MobileNamber,
                Nation = student.Nation,
                Cours = student.Cours,
                LiveReady = student.LiveReady,
                Contract = student.Contract,
                Nogiron = student.Nogiron,
                RegionId = student.RegionId,
                DistrictId = student.DistrictId,
                GroupId = student.GroupId,
                InteristId = student.InteristId,
                InteristTypeId = student.InteristTypeId,
                FacultyId = student.FacultyId,
                BranchId = student.BranchId,
                PhotoFilePath = uniqueFileName
            };
            NewStudent = repository.Create(NewStudent);
            return RedirectToAction("Index");
        }

        private string ProcsessUploudFile(StudentCreateViewModel student)
        {
            string uniqueFileName = string.Empty;
            if (student.Photo != null)
            {
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + student.Photo.FileName;
                string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
                student.Photo.CopyTo(new FileStream(imageFilePath, FileMode.Create));
            }

            return uniqueFileName;
        }

        [HttpGet]
        public ViewResult Edit(int id) 
        {
            var x = repository.GetInterists();
            ViewData["interist"] = new SelectList(x, "Id", "Name");
            var y = repository.GetRegions();
            ViewData["region"] = new SelectList(y, "Id", "RegionName");
            var z = repository.GetFaculties();
            ViewData["faculty"] = new SelectList(z, "Id", "FacultyName");
            var student = repository.GetById(id);
            StudentEditViewModel viewModel = new StudentEditViewModel
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                SureName = student.SureName,
                Birthday = student.Birthday,
                Passport = student.Passport,
                Gender = student.Gender,
                MobileNamber = student.MobileNamber,
                Nation = student.Nation,
                Cours = student.Cours,
                LiveReady = student.LiveReady,
                Contract = student.Contract,
                Nogiron = student.Nogiron,
                RegionId = student.RegionId,
                DistrictId = student.DistrictId,
                GroupId = student.GroupId,
                InteristId = student.InteristId,
                InteristTypeId = student.InteristTypeId,
                FacultyId = student.FacultyId,
                BranchId = student.BranchId,
                ExsitingPhotoFilePath = student.PhotoFilePath
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(StudentEditViewModel student) 
        {
            var exsitingStudent = repository.GetById(student.StudentId);
            exsitingStudent.FirstName = student.FirstName;
            exsitingStudent.LastName = student.LastName;
            exsitingStudent.SureName = student.SureName;
            exsitingStudent.Birthday = student.Birthday;
            exsitingStudent.Passport = student.Passport;
            exsitingStudent.Gender = student.Gender;
            exsitingStudent.MobileNamber = student.MobileNamber;
            exsitingStudent.Nation = student.Nation;
            exsitingStudent.Cours = student.Cours;
            exsitingStudent.LiveReady = student.LiveReady;
            exsitingStudent.Contract = student.Contract;
            exsitingStudent.Nogiron = student.Nogiron;
            exsitingStudent.RegionId = student.RegionId;
            exsitingStudent.DistrictId = student.DistrictId;
            exsitingStudent.GroupId = student.GroupId;
            exsitingStudent.InteristId = student.InteristId;
            exsitingStudent.InteristTypeId = student.InteristTypeId;
            exsitingStudent.FacultyId = student.FacultyId;
            exsitingStudent.BranchId = student.BranchId;
            exsitingStudent.GroupId = student.GroupId;
            if (student.Photo != null)
            {
                if (student.ExsitingPhotoFilePath != null)
                {
                    string filepath = Path.Combine(webHost.WebRootPath, "images", student.ExsitingPhotoFilePath);
                    System.IO.File.Delete(filepath);
                }
                exsitingStudent.PhotoFilePath = ProcsessUploudFile(student);
            }
            repository.Update(exsitingStudent);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id) 
        {
            var student = repository.GetById(id);
            if (student.PhotoFilePath != null)
            {
                string filepath = Path.Combine(webHost.WebRootPath, "images", student.PhotoFilePath);
                System.IO.File.Delete(filepath);
            }
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
