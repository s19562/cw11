using cwiczenie11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenie11.Service
{
    public class DbService : IDbService
    {
        MediDbContext _context;

        public DbService(MediDbContext context)
        {
            _context = context;
        }

        public Doctor GetDoctor(int IdDoctor)
        {
            return _context.Doctor.First(a => a.IdDoctor == IdDoctor);

        }

        public string AddDoctor (Doctor doctor)
        {
            _context.Doctor.Add(doctor);
            return "Koniec procedury dodania";
        }

        public string ModifyDoctor(Doctor doctorNew)
        {
            var doktor = _context.Doctor.First(a => a.IdDoctor == doctorNew.IdDoctor);

            if ( doktor != null)
            {

                doktor.FirstName = doctorNew.FirstName;
                doktor.LastName = doctorNew.LastName;
                doktor.Email = doctorNew.Email;

            }
            return "Koniec procedury modyfikowania";

        }

        public string DeleteDoctor (int IdDoctor)
        {
            var doktor = _context.Doctor.First(a => a.IdDoctor == IdDoctor);

            if(doktor != null)
            {
                _context.Doctor.Remove(doktor);
            }
            return "Koniec procedury usuwania";
        }


    }
}
