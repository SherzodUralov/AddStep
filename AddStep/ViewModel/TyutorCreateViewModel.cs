using AddStep.Attributes;
using AddStep.Models.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.ViewModel
{
    public class TyutorCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string SureName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public int Internship { get; set; }
        [Required]
        public string MobileNamber { get; set; }
        [Required]
        public Genders? Gender { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        [AlowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }
        public string Passport { get; set; }
    }
}
