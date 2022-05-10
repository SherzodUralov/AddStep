using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Branch
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="BranchName")]
        public string BranchName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

    }
}
