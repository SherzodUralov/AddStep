using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class District
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        [Display(Name ="DistrictName")]
        public string DistrictName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Tyutor> Tyutors { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
