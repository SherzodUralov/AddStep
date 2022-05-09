using AddStep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<StudentIndexViewModel> GetAll();
        Student Create(Student student);
        Student Update(Student student);
        Student Delete(int id);
        IList<Interist> GetInterists();
        IList<InteristType> GetInteristTypes(int interistid);
        IList<Region> GetRegions();
        IList<District> GetDistricts(int regionid);
        IList<Faculty> GetFaculties();
        IList<Branch> GetBranches(int facultyid);
        IList<Group> GetGroups(int branchid);

    }
}
