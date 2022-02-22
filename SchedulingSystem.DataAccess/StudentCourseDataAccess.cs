using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess.Models;

namespace SchedulingSystem.DataAccess
{
    public class StudentCourseDataAccess : IStudentCourseDataAccess
    {
        private ScheduleSystemDBContext _DbContext;
        public StudentCourseDataAccess(ScheduleSystemDBContext dbContext)
        {
            _DbContext = dbContext;
        }

        public object GetStudentCourses(int studentId)
        {
            try
            {
                var studentEnrolledCourses = (from student in _DbContext.Students
                                              where student.StudentID == studentId
                                              from studentCourse in student.StudentCourses
                                              select new
                                              {
                                                  StudentName = student.FirstName + " " + student.LastName,
                                                  CourseName = studentCourse.Course.Title,
                                                  EnrolledDate = studentCourse.EnrolledDate

                                              }).ToList();

                return studentEnrolledCourses;
            }
            catch
            {
                throw;
            }
        }

        public void AssignStudentToClass(int studentId, int courseId)
        {
            try
            {
                _DbContext.StudentCourses.Add(new StudentCourse
                { StudentID = studentId, CourseID = courseId, EnrolledDate = DateTime.Now });

                _DbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }

        public void DeleteStudent(int studentId, int courseId)
        {
            try
            {
                StudentCourse studentCourseToRemove = _DbContext.StudentCourses
                .FirstOrDefault(x => x.StudentID == studentId && x.CourseID == courseId);
                _DbContext.StudentCourses.Remove(studentCourseToRemove);
                _DbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }
    }
}
