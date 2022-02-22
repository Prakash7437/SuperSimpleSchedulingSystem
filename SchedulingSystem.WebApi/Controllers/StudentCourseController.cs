using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchedulingSystem.Business;

namespace SchedulingSystem.WebApi.Controllers
{
    public class StudentCourseController : ApiController
    {
        private IStudentCourseBusiness _studentCourseBusiness;

        public StudentCourseController(IStudentCourseBusiness studentCourseBusiness)
        {
            _studentCourseBusiness = studentCourseBusiness;
        }

        //GET - to get student registed courses
        [HttpGet]
        public object GetStudentCourses(int studentId)
        {
            try
            {
                var studentCourses = _studentCourseBusiness.GetStudentCourses(studentId);

                if (studentCourses == null)
                {
                    string message = string.Format("Students not registered to any cousre");
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }

                return Request.CreateResponse(HttpStatusCode.OK, studentCourses);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
        }

        // POST - to assign student to course
        [HttpPost]
        public void AssignStudentToClass(int studentId, int courseId)
        {
            try
            {
                _studentCourseBusiness.AssignStudentToClass(studentId, courseId);
            }
            catch
            {
                //Handle exceptions here
            }
        }

        // DELETE - to delete student from course
        [HttpDelete]
        public void DeleteStudent(int studentId, int courseId)
        {
            try
            {
                _studentCourseBusiness.DeleteStudent(studentId, courseId);
            }
            catch
            {
                //Handle Exceptions here
            }
            
        }
    }
}
