using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenie11.Models
{
    public class MediDbContext : DbContext
    {

        public DbSet<Doctor> Doctor { get; set; }
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

            var listaDoktor = new List<Doctor>();

            listaDoktor.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Pati",
                LastName = "Dan",
                Email = "doktor1@wp.pl"

            });

            listaDoktor.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Stefan",
                LastName = "Bran",
                Email = "doktor2@wp.pl"

            });

            var listaPacjent = new List<Patient>();

            listaPacjent.Add(new Patient
            {
                IdPatient = 100,
                FirstName = "Pit",
                LastName = "Adamczyk",
                MyProperty = DateTime.Now
            });

            listaPacjent.Add(new Patient
            {
                IdPatient = 101,
                FirstName = "Artur",
                LastName = "Potep",
                MyProperty = DateTime.Now
            });

            var listMedi = new List<Medicament>();
            listMedi.Add(new Medicament
            {
                IdMedicament = 1, 
                Name = "Lewatywa", 
                Description = "heh", 
                Type = "niebezpieczne"
            });

            listMedi.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "wizyta",
                Description = "nic",
                Type = "normalna"
            });

            var listaPre = new List<Prescription>();
            listaPre.Add(new Prescription
            {

                IdPrescription = 1, 
                Date = DateTime.Now,
                DueDate = DateTime.Now , 
                IdPatient = 100 , 
                IdDoctor = 1
            });

            var listaOba = new List<Prescription_Medicament>();
            listaOba.Add(new Prescription_Medicament
            {
                id =1,
                IdMedicament = 1, 
                IdPrescription = 1,
                Dose = 11,
                Details = "cos tam"
            });



            builder.Entity<Doctor>().HasData(listaDoktor);
            builder.Entity<Patient>().HasData(listaPacjent);
            builder.Entity<Medicament>().HasData(listMedi);
            builder.Entity<Prescription>().HasData(listaPre);
            builder.Entity<Prescription_Medicament>().HasData(listaOba);

        }



    }
}
