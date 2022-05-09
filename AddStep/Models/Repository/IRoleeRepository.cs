using AddStep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public interface IRoleeRepository
    {
        Rolee GetById(int id);
        IEnumerable<RoleeIndexViewModel> GetByAll();
        Rolee Create(Rolee rolee);
        Rolee Update(Rolee rolee);
        Rolee Delete(int id);
        IList<Group> GetGroups();
        IList<Tyutor> GetTyutors();
    }
}
