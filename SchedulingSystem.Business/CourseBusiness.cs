using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess.Models;
using SchedulingSystem.DataAccess;

namespace SchedulingSystem.Business
{
    public class CourseBusiness : ICourseBusiness
    {
        public ICourseDataAccess _courseDataAccess;
        public CourseBusiness(ICourseDataAccess courseDataAccess)
        {
            _courseDataAccess = courseDataAccess;
        }

        public void CreateCourse(Course course)
        {
            try
            {
                _courseDataAccess.CreateCourse(course);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteCourse(int courseId)
        {
            try
            {
                _courseDataAccess.DeleteCourse(courseId);
            }
            catch
            {
                throw;
            }
        }

        public Course GetCourse(int courseId)
        {
            try
            {
                var course = _courseDataAccess.GetCourse(courseId);
                return course;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Course> GetCourses()
        {
            try
            {
                var courses = _courseDataAccess.GetCourses();
                return courses;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateCourse(int courseId, Course course)
        {
            try
            {
                _courseDataAccess.UpdateCourse(courseId, course);
            }
            catch
            {
                throw;
            }
        }
    }
}
