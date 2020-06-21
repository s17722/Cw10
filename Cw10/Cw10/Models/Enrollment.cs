using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cw10.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEnrollment { get; set; }

        public int Semester { get; set; }

        [ForeignKey("Studies")]
        public int IdStudy { get; set; }
        public virtual Studies Studies { get; set; }

        public DateTime StartDate { get; set; }
    }
}
