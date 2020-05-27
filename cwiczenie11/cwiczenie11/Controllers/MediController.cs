using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cwiczenie11.Models;
using cwiczenie11.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenie11.Controllers
{
    [Route("api/med")]
    [ApiController]
    public class MediController : ControllerBase
    {

        private readonly IDbService _context;
        public MediController(IDbService context)
        {
            _context = context;
        }

        [HttpGet("{IdDoctor}")]
        public IActionResult GetDoctor(int IdDoctor)
        {
            Doctor result = _context.GetDoctor(IdDoctor);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return NotFound("not found");

        }


        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            String result = _context.AddDoctor(doctor);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return NotFound("not found");


        }

        [HttpDelete("{IdDoctor}")]
        public IActionResult DeleteDoctor(int IdDoctor)
        {
            String result = _context.DeleteDoctor(IdDoctor);
            return Ok("Sprawdz czy usunął");
        }

        [HttpPost]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            String result = _context.ModifyDoctor(doctor);

            if (result != null)
            {
                return Ok(result);
            }
            else
                return NotFound("not found");
        }
    }
}