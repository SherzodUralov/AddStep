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
    public class RoleeController : Controller
    {
        private readonly IRoleeRepository repository;

        public RoleeController(IRoleeRepository repository)
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
            var x = repository.GetGroups();
            ViewData["group"] = new SelectList(x, "Id", "GroupName");
            var y = repository.GetTyutors();
            ViewData["tyutor"] = new SelectList(y, "TyutorId", "Passport");
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoleeCreateViewModel rolee) 
        {
            Rolee rolee1 = new Rolee
            {
                Id = rolee.Id,
                GroupId = rolee.GroupId,
                TyutorId = rolee.TyutorId
            };
            rolee1 = repository.Create(rolee1);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Edit(int id) 
        {
            var x = repository.GetGroups();
            ViewData["group"] = new SelectList(x, "Id", "GroupName");
            var y = repository.GetTyutors();
            ViewData["tyutor"] = new SelectList(y, "TyutorId", "Passport");

            var role = repository.GetById(id);

            RoleeEditViewModel roleeEdit = new RoleeEditViewModel
            {
                Id = role.Id,
                GroupId = role.GroupId,
                TyutorId = role.TyutorId
            };
            return View(roleeEdit);
        }
        [HttpPost]
        public IActionResult Edit(RoleeEditViewModel roleeEdit) 
        {
            Rolee Exsitrole = repository.GetById(roleeEdit.Id);

            Exsitrole.GroupId = roleeEdit.GroupId;
            Exsitrole.TyutorId = roleeEdit.TyutorId;

            repository.Update(Exsitrole);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id) 
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
