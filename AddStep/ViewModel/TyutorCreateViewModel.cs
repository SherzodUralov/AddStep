using AddStep.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.ViewModel
{
    public class TyutorCreateViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        public int Internship { get; set; }
        public string MobileNamber { get; set; }
        public Genders? Gender { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
    }
}
