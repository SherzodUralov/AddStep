using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class InteristType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InteristId { get; set; }
        public Interist Interist { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
