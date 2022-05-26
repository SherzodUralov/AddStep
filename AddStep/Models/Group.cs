using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Group
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="GroupName")]
        public string GroupName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Rolee> Rolees { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }


    }
}
