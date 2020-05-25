using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenie11.Models
{
    public class MediDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        public MediDbContext()
        {

        }

        public MediDbContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Doctor>((builder) =>
            {
                builder.HasKey(a => a.IdDoctor);
                builder.Property(a => a.FirstName).IsRequired();


            });
        }



    }
}
