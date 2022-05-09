using AddStep.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.ViewModel
{
    public class StudentIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Cours { get; set; }
        public DateTime Birthday { get; set; }
        public string Passport { get; set; }
        public Genders? Gender { get; set; }
        public string MobileNamber { get; set; }
        public string RegionName { get; set; }
        public string DistrictName { get; set; }
        public string InteristName { get; set; }
        public string InteristTypeName { get; set; }
        public string FacultyName { get; set; }
        public string BranchName { get; set; }
        public string GroupName { get; set; }
        public string PhotoFile { get; set; }
    }
}
