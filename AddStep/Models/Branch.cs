using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Branch
    {
        [Key]
        [MaxLength(7)]
        public string Code { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="BranchName")]
        public string BranchName { get; set; }
        [ForeignKey("Faculty")]
        
    }
}
