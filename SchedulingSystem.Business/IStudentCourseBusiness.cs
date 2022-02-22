using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.Business
{
    public interface IStudentCourseBusiness
    {
        object GetStudentCourses(int studentId);
        void AssignStudentToClass(int studentId, int classId);
        void DeleteStudent(int studentId, int classId);
    }
}
