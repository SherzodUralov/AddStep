using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Region
    {
        [Key]
        public int  Id { get; set; }
        [MaxLength(35)]
        public string RegionName { get; set; }

    }
}
