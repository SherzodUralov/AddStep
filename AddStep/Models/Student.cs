
using AddStep.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Student
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
        public string PhotoFilePath { get; set; }
        public Nations? Nation { get; set; }
        public int Cours { get; set; }
        public LiveTypes? LiveReady { get; set; }
        public Contracts? Contract { get; set; }
        public Nogirons? Nogiron { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int InteristId { get; set; }
        public Interist Interist { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }
        public int IlmiyId { get; set; }
        public Ilmiy Ilmiy { get; set; }
        public int MusiqaId { get; set; }
        public Musiqa Musiqa { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }




    }
}
