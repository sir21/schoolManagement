using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.Models;
using Microsoft.EntityFrameworkCore;

namespace SMS.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Enrolled>().ToTable("Enrolled");
            modelBuilder.Entity<Class>().ToTable("Class");
        }
    }
}
