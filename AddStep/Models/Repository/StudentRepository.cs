using AddStep.Models.Context;
using AddStep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Student Create(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            var student = dbContext.Students.Find(id);
            if (student != null)
            {
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
            }
            return student;
        }

        public IEnumerable<StudentIndexViewModel> GetAll(string Searchtext)
        {
            var model = dbContext.Students.Select(w => new StudentIndexViewModel
            {
                Id = w.StudentId,
                Name = w.FirstName,
                LastName = w.LastName,
                Cours = w.Cours,
                Birthday = w.Birthday,
                Passport = w.Passport,
                Gender = w.Gender,
                MobileNamber = w.MobileNamber,
                RegionName = w.Region.RegionName,
                DistrictName = w.District.DistrictName,
                InteristName = w.Interist.Name,
                InteristTypeName = w.InteristType.Name,
                FacultyName = w.Faculty.FacultyName,
                BranchName = w.Branch.BranchName,
                GroupName = w.Group.GroupName,
                PhotoFile = w.PhotoFilePath

            });
            if (!string.IsNullOrEmpty(Searchtext))
            {
                model = model.Where(n => n.Name.Contains(Searchtext));
            }
            return model;
        }

        public IList<Branch> GetBranches(int facultyid)
        {
            return dbContext.Branches.Where(w => w.FacultyId.Equals(facultyid)).ToList();
        }

        public Student GetById(int id)
        {
            return dbContext.Students.Find(id);
        }

        public IList<District> GetDistricts(int regionid)
        {
            return dbContext.Districts.Where(l => l.RegionId.Equals(regionid)).ToList();
        }

        public IList<Faculty> GetFaculties()
        {
            return dbContext.Faculties.ToList();
        }

        public IList<Group> GetGroups(int branchid)
        {
            return dbContext.Groups.Where(w => w.BranchId.Equals(branchid)).ToList();
        }

        public IList<Interist> GetInterists()
        {
            return dbContext.Interists.ToList();
        }

        public IList<InteristType> GetInteristTypes(int interistid)
        {
            return dbContext.InteristTypes.Where(l => l.InteristId.Equals(interistid)).ToList();
        }

        public IList<Region> GetRegions()
        {
            return dbContext.Regions.ToList();
        }

        public Student Update(Student student)
        {
            dbContext.Students.Update(student);
            dbContext.SaveChanges();
            return student;
        }
    }
}
