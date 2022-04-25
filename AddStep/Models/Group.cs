﻿using System;
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
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="GroupName")]
        public string GroupName { get; set; }
        public Tyutor Tyutor { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }


    }
}
