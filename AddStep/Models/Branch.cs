﻿using System;
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
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="BranchName")]
        public string BranchName { get; set; }
        
    }
}
