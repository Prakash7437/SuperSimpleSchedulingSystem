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
    public class CourseController : ApiController
    {
        private ICourseBusiness _courseBusiness;

        public CourseController(ICourseBusiness courseBusiness)
        {
            _courseBusiness = courseBusiness;
        }

        // GET - to get all courses
        [HttpGet]
        public HttpResponseMessage Getcourses()
        {

            var courses = new List<Course>();
            try
            {
                courses = _courseBusiness.GetCourses().ToList();

                if (courses.Count == 0)
                {
                    string message = string.Format("No courses found in DB");
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }

            return Request.CreateResponse(HttpStatusCode.OK, courses);

        }

        // POST - to create new course
        [HttpPost]
        public void CreateCourse(Course course)
        {
            try
            {
                _courseBusiness.CreateCourse(course);
            }
            catch
            {
                //Handle exceptions here
            }
            
        }

        // PUT - to update existing course 
        [HttpPut]
        public void UpdateCourse(int courseId, Course course)
        {
            try
            {
                _courseBusiness.UpdateCourse(courseId, course);
            }
            catch
            {
                //Handle exceptions here
            }


        }

        // DELETE - to delete couse with matching courseid
        [HttpDelete]
        public void DeleteCourse(int courseId)
        {
            try
            {
                _courseBusiness.DeleteCourse(courseId);
            }
            catch
            {
                //Handle exceptions here
            }

        }
    }
}
