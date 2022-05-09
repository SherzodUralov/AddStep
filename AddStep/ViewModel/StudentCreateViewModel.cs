using AddStep.Models.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.ViewModel
{
    public class StudentCreateViewModel
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(30)]
        public string Passport { get; set; }
        public Genders? Gender { get; set; }
        [Required]
        [MaxLength(30)]
        public string MobileNamber { get; set; }
        public Nations? Nation { get; set; }
        public int Cours { get; set; }
        public LiveTypes? LiveReady { get; set; }
        public Contracts? Contract { get; set; }
        public Nogirons? Nogiron { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        public int GroupId { get; set; }
        public int InteristId { get; set; }
        public int InteristTypeId { get; set; }
        public int FacultyId { get; set; }
        public int BranchId { get; set; }
        public IFormFile Photo { get; set; }

    }
}
