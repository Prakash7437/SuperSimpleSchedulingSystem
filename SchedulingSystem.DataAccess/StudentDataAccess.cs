using SchedulingSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchedulingSystem.DataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private ScheduleSystemDBContext _DbContext;
        public StudentDataAccess(ScheduleSystemDBContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IEnumerable<Student> GetStudents()
        {
            try
            {
                return _DbContext.Students.ToList();
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
                var student = _DbContext.Students.SingleOrDefault(s => s.StudentID == studentId);
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
                _DbContext.Students.Add(student);
                _DbContext.SaveChanges();
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
                var studentInDb = _DbContext.Students.SingleOrDefault(s => s.StudentID == studentId);
                if (studentInDb != null)
                {
                    studentInDb.LastName = student.LastName;
                    studentInDb.FirstName = student.FirstName;
                    _DbContext.SaveChanges();
                }
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
                var studentInDb = _DbContext.Students.SingleOrDefault(s => s.StudentID == studentId);
                if (studentInDb != null)
                {
                    _DbContext.Students.Remove(studentInDb);
                    _DbContext.SaveChanges();
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
