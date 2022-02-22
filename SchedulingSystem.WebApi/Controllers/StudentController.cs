using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchedulingSystem.Business;
using SchedulingSystem.DataAccess.Models;

namespace SchedulingSystem.WebApi.Controllers
{
    public class StudentController : ApiController
    {
        public IStudentBusiness _studentBusiness;

        public StudentController(IStudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;
        }

        //GET - to get all students
        [HttpGet]
        public HttpResponseMessage GetStudents()
        {
            var students = new List<Student>();
            try
            {
                students = _studentBusiness.GetStudents().ToList();

                if (students.Count == 0)
                {
                    string message = string.Format("No students found in DB");
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }

            return Request.CreateResponse(HttpStatusCode.OK, students);
        }

        //POST - to create a new student
        [HttpPost]
        public void CreateStudent(Student student)
        {
            try
            {
                _studentBusiness.CreateStudent(student);
            }
            catch
            {
                //Handle Exceptions here
            }
            
        }        

        //PUT - to update an existing student details
        [HttpPut]
        public void UpdateStudent(int studentId, Student student)
        {
            try
            {
                _studentBusiness.UpdateStudent(studentId, student);
            }
            catch (Exception ex)
            {       
                //Handle Exceptions here
            }
            
        }

        // DELETE - to delete existing student
        [HttpDelete]
        public void DeleteStudent(int studentId)
        {  
            try
            {
                _studentBusiness.DeleteStudent(studentId);
            }
            catch (Exception ex)
            {
                //Handle exceptions here
            }
        }
    }
}
