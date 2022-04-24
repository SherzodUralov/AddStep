using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        Student Create(Student student);
        Student Update(Student student);
        Student Delete(int id);
    }
}
