using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess;

namespace SchedulingSystem.Business
{
    public class StudentCourseBusiness : IStudentCourseBusiness
    {
        public IStudentCourseDataAccess _studentCourseDataAccess;
        public StudentCourseBusiness(IStudentCourseDataAccess studentCourseDataAccess)
        {
            _studentCourseDataAccess = studentCourseDataAccess;
        }

        public object GetStudentCourses(int studentId)
        {
            try
            {
                var studentCourses = _studentCourseDataAccess.GetStudentCourses(studentId);
                return studentCourses;
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
                _studentCourseDataAccess.AssignStudentToClass(studentId, courseId);
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
                _studentCourseDataAccess.DeleteStudent(studentId, courseId);
            }
            catch
            {
                throw;
            }
        }
    }
}
