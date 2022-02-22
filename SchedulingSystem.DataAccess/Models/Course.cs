using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.DataAccess.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
