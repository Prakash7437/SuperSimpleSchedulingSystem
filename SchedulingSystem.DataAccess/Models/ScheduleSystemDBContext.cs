using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchedulingSystem.DataAccess.Models
{
    public class ScheduleSystemDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
