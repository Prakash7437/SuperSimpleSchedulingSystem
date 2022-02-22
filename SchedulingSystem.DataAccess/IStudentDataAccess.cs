using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess.Models;

namespace SchedulingSystem.DataAccess
{
    public interface IStudentDataAccess
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int studentId);
        void CreateStudent(Student student);
        void UpdateStudent(int studentId, Student student);
        void DeleteStudent(int studentId);
    }
}
