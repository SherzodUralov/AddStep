using AddStep.Models;
using AddStep.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.ViewModel
{
    public class TyutorIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Staj { get; set; }
        public string MobileNamber { get; set; }
        public Genders? Gender { get; set; }
        public string RegionName { get; set; }
        public string DistrictName { get; set; }
        public string PhotoFile { get; set; }
        public string PassportSeris { get; set; }

    }
}
