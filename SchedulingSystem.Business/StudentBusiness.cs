using SchedulingSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingSystem.DataAccess;

namespace SchedulingSystem.Business
{
    public class StudentBusiness : IStudentBusiness
    {
        public IStudentDataAccess _studentDataAccess;
        public StudentBusiness(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess = studentDataAccess;
        }

        public IEnumerable<Student> GetStudents()
        {
            try
            {
                var students = _studentDataAccess.GetStudents();
                return students;
            }
            catch
            {
                throw;
            }
        }

        public Student GetStudent(int studentId)
        {
            try
            {
                var student = _studentDataAccess.GetStudent(studentId);
                return student;
            }
            catch
            {
                throw;
            }
        }

        public void CreateStudent(Student student)
        {
            try
            {
                _studentDataAccess.CreateStudent(student);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateStudent(int studentId, Student student)
        {
            try
            {
                _studentDataAccess.UpdateStudent(studentId, student);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteStudent(int studentId)
        {
            try
            {
                _studentDataAccess.DeleteStudent(studentId);
            }
            catch
            {
                throw;
            }
        }
    }
}
