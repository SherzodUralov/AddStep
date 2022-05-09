using AddStep.Models.Context;
using AddStep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public class RoleeRepository : IRoleeRepository
    {
        private readonly AppDbContext context;

        public RoleeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Rolee Create(Rolee rolee)
        {
            context.Rolees.Add(rolee);
            context.SaveChanges();
            return rolee;
        }

        public Rolee Delete(int id)
        {
            var model = context.Rolees.Find(id);
            if (model != null)
            {
                context.Rolees.Remove(model);
                context.SaveChanges();
            }
            return model;
        }

        public IEnumerable<RoleeIndexViewModel> GetByAll()
        {
            var model = context.Rolees.Select(w => new RoleeIndexViewModel
            {
                RoleId = w.Id,
                GroupName = w.Group.GroupName,
                TyutorName = w.Tyutor.FirstName,
                PassportSeriss = w.Tyutor.Passport
            });
            return model;
        }

        public Rolee GetById(int id)
        {
            return context.Rolees.Find(id);
        }

        public IList<Group> GetGroups()
        {
            return context.Groups.ToList();
        }

        public IList<Tyutor> GetTyutors()
        {
            return context.Tyutors.ToList();
        }

        public Rolee Update(Rolee rolee)
        {
            context.Rolees.Update(rolee);
            context.SaveChanges();
            return rolee;
        }
    }
}
