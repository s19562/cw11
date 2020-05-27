using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenie11.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime MyProperty { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }


    }
}
