using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Group
    {
        [Key]
        [MaxLength(6)]
        public string Code { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="GroupName")]
        public string GroupName { get; set; }
        

    }
}
