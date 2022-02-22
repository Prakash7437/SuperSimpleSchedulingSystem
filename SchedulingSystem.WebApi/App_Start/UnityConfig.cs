using System.Web.Http;
using Unity;
using Unity.WebApi;
using SchedulingSystem.DataAccess;
using SchedulingSystem.Business;

namespace SchedulingSystem.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentBusiness, StudentBusiness>();
            container.RegisterType<IStudentDataAccess, StudentDataAccess>();
            container.RegisterType<ICourseBusiness, CourseBusiness>();
            container.RegisterType<ICourseDataAccess, CourseDataAccess>();
            container.RegisterType<IStudentCourseBusiness, StudentCourseBusiness>();
            container.RegisterType<IStudentCourseDataAccess, StudentCourseDataAccess>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}