using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddStep.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public virtual DbSet<Tyutor> Tyutors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Interist> Interists { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<InteristType> InteristTypes { get; set; }
        public virtual DbSet<Rolee> Rolees { get; set; }
    }
}
