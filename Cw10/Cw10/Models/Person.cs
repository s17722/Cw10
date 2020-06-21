using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
