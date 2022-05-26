using AddStep.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Tyutor
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TyutorId { get; set; }
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
        public int Staj { get; set; }
        [Required]
        [MaxLength(30)]
        public string MobileNamber { get; set; }
        public string PhotoFilePath { get; set; }
        public string Passport { get; set; }
        public string Resime { get; set; }
        public Genders? Gender { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Rolee> Rolees { get; set; }

    }
}
