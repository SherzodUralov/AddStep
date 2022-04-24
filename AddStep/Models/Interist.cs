using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Interist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sport> Sports { get; set; }
        public virtual ICollection<Ilmiy> Ilmiys { get; set; }
        public virtual ICollection<Musiqa> Musiqas { get; set; }
        public virtual ICollection<Student> Students { get; set; }


    }
}
