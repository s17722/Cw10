using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Models
{
    public class Student
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IndexNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }


        public DateTime BirthDate { get; set; }

        [ForeignKey("Enrollment")]
        public int IdEnrollment { get; set; }
        public virtual Enrollment Enrollment { get; set; }

    }
}
