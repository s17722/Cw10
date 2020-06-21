using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cw10.Models;
using Cw10.Services;

namespace Cw10.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentDbService _context;

        public StudentsController(IStudentDbService context)
        {
            _context = context;
        }

        //ZADANIE 2 - zwrocenie listy studentow
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.GetStudents());
        }

        //ZADANIE 2 - modyfikacja nazwiska studenta
        [HttpPut("{indexNumber}")]
        public IActionResult UpdateStudent(string indexNumber, string lastName)
        {
            _context.UpdateStudent(indexNumber, lastName);
            return Ok("Zaktualizowano nazwisko");
        }



        //ZADANIE 2 - usuniecie studenta
            //
        [HttpDelete("{indexNumber}")]
        public IActionResult RemoveStudent(string indexNumber)
        {

            _context.RemoveStudent(indexNumber);

            return Ok("Usuwanie zakonczono");
        }

    }
}
