using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.DataAccess
{
    public interface IStudentCourseDataAccess
    {
        object GetStudentCourses(int studentId);
        void AssignStudentToClass(int studentId, int courseId);
        void DeleteStudent(int studentId, int courseId);
    }
}
