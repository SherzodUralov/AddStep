using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public interface ITyutorRepository
    {
        Tyutor GetById(int id);
        IEnumerable<Tyutor> GetAll();
        Tyutor Create(Tyutor tyutor);
        Tyutor Update(Tyutor tyutor);
        Tyutor Delete(int id);
    }
}
