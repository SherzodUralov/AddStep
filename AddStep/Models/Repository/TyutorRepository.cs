using AddStep.Models.Context;
using AddStep.ViewModel;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Repository
{
    public class TyutorRepository : ITyutorRepository
    {
        private readonly AppDbContext dbContext;

        public TyutorRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Tyutor Create(Tyutor tyutor)
        {
            dbContext.Tyutors.Add(tyutor);
            dbContext.SaveChanges();
            return tyutor;
        }

        public Tyutor Delete(int id)
        {
            var tyutor = dbContext.Tyutors.Find(id);
            if (tyutor != null)
            {
                dbContext.Tyutors.Remove(tyutor);
                dbContext.SaveChanges();
            }
            return tyutor;
        }

        public IEnumerable<TyutorIndexViewModel> GetByAll(string SearchText)
        {
                var model = dbContext.Tyutors.Select(w => new TyutorIndexViewModel
                {
                    Id = w.TyutorId,
                    Name = w.FirstName,
                    LastName = w.LastName,
                    Staj = w.Staj,
                    MobileNamber = w.MobileNamber,
                    Gender = w.Gender,
                    RegionName = w.Region.RegionName,
                    DistrictName = w.District.DistrictName,
                    PhotoFile = w.PhotoFilePath,
                    PassportSeris = w.Passport
                });
           
                if (!string.IsNullOrEmpty(SearchText))
                {
                model = model.Where(n => n.Name.Contains(SearchText));
                }
                return model;
            
                
        }

        public IList<Tyutor> GetByALl()
        {
            return dbContext.Tyutors.ToList();
        }

        public Tyutor GetById(int id)
        {
            return dbContext.Tyutors.Find(id);
        }

        public IList<District> GetDistricts(int regionId)
        {
            return dbContext.Districts.Where(l => l.RegionId == regionId).ToList();
        }

        public IList<Region> GetRegions()
        {
            return dbContext.Regions.ToList();
        }

        public Tyutor Update(Tyutor tyutor)
        {
            dbContext.Tyutors.Update(tyutor);
            dbContext.SaveChanges();
            return tyutor;
        }
    }
}
