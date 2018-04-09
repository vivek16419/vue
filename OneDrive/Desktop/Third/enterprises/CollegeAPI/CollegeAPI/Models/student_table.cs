using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAPI.Models
{
    public class student_table
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
