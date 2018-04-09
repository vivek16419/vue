using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAPI.Models
{
    public class StudentData : DbContext
    {
        // constructor
        public StudentData(DbContextOptions<StudentData>options) :base(options)
        {

        }
    }
}
