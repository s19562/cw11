using cwiczenie11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenie11.Service
{
    public interface IDbService
    {

        Doctor GetDoctor(int IdDoctor);
        string AddDoctor(Doctor doctor);
        string ModifyDoctor(Doctor doctor);
        string DeleteDoctor(int IdDoctor);

    }
}
