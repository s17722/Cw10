using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Models
{
    public class PeopleDbContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public DbSet<Student> Student { get; set; } 
        public DbSet<Enrollment> Enrollment { get; set; } 
        public DbSet<Studies> Studies { get; set; } 

        public PeopleDbContext() { }

        public PeopleDbContext (DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new StudiesEfConfiguration());

            //FluentAPI
            /*
            modelBuilder.Entity<Studies>()
                        .HasKey(e => e.IdStudies); //[Key]

            modelBuilder.Entity<Studies>()
                        .Property(e => e.Name)
                        .HasMaxLength(100) //[MaxLength(100)]
                        .IsRequired(); // [Required]

            var dictStudies = new List<Studies>();
            dictStudies.Add(new Studies { IdStudies = 1, Name = "IT", Description = "AAA" });
            dictStudies.Add(new Studies { IdStudies = 2, Name = "Graphic design", Description = "BBB" });

            modelBuilder.Entity<Studies>()
                        .HasData(dictStudies);
            */

        }

    }
}
