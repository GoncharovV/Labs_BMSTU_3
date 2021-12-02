using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DatabaseContext
{
    public class DoctorsContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

        public DoctorsContext() { }

        public DoctorsContext(DbContextOptions<DoctorsContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=root;Server=localhost;Port=5432;Database=doctors;");
        }
    }
}
