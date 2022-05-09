using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models
{
    public class Rolee
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int  TyutorId { get; set; }
        public Tyutor Tyutor { get; set; }
    }
}
