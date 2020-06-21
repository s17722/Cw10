using Cw10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Services
{
    public class EfStudentDbService : IStudentDbService
    {

        private readonly PeopleDbContext _context;

        public EfStudentDbService(PeopleDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Student.ToList();
        }

        public void RemoveStudent(string indexNumber)
        {
            if (indexNumber != null) 
            { 
                var student = _context.Student.SingleOrDefault(x => x.IndexNumber == indexNumber);

                _context.Student.Remove(student);
                _context.SaveChanges();
            }


        }

        public void UpdateStudent(string indexNumber, string lastName)
        {
            if (indexNumber != null)
            {
                var student = _context.Student.Find(indexNumber);

                if (lastName != null)
                    student.LastName = lastName;
                    _context.SaveChanges();
            }
        }
    }
}
