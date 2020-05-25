using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cwiczenie11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenie11.Controllers
{
    [Route("api/med")]
    [ApiController]
    public class MediController : ControllerBase
    {

        private readonly MediDbContext _context;
        public MediController(MediDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok();
        }

    }
}