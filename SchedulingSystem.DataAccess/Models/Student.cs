using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.DataAccess.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
