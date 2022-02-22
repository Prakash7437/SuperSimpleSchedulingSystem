using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess.Models;

namespace SchedulingSystem.Business
{
    public interface ICourseBusiness
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(int courseId);
        void CreateCourse(Course course);
        void UpdateCourse(int courseId, Course course);
        void DeleteCourse(int courseId);
    }
}
