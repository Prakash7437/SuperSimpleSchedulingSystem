using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess.Models;

namespace SchedulingSystem.DataAccess
{
    public class CourseDataAccess : ICourseDataAccess
    {
        private ScheduleSystemDBContext _DbContext;
        public CourseDataAccess(ScheduleSystemDBContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            try
            {
                return _DbContext.Courses.ToList();
            }
            catch
            {
                throw;
            }
            
        }

        public Course GetCourse(int id)
        {
            try { 
            var course = _DbContext.Courses.SingleOrDefault(s => s.CourseID == id);

            if (course == null)
                throw new NullReferenceException("No record found with the Id");

            return course;
            }
            catch
            {
                throw;
            }
        }

        public void CreateCourse(Course course)
        {
            try
            {
                _DbContext.Courses.Add(course);
                _DbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }


        public void UpdateCourse(int id, Course course)
        {
            try
            {
                var courseInDb = _DbContext.Courses.SingleOrDefault(c => c.CourseID == id);

                if (courseInDb == null)
                    throw new Exception("No recourd found with the Id");

                courseInDb.Title = course.Title;
                courseInDb.Description = course.Description;

                _DbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }


        public void DeleteCourse(int id)
        {
            try
            {
                var courseInDb = _DbContext.Courses.SingleOrDefault(c => c.CourseID == id);

                if (courseInDb == null)
                    throw new Exception("No recourd found with the Id");

                _DbContext.Courses.Remove(courseInDb);
                _DbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }
    }
}
