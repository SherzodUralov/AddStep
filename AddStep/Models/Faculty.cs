using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Faculty
    {
        [Key]
        [MaxLength(7)]
        public string Code { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="FacultyName")]
        public string FacultyName { get; set; }
        

    }
}
