using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.DataAccess.Models
{
    public class StudentCourse
    {
        public Course Course { get; set; }

        public Student Student { get; set; }

        [Key, Column(Order = 1)]
        public int StudentID { get; set; }

        [Key, Column(Order = 2)]
        public int CourseID { get; set; }
        public DateTime EnrolledDate { get; set; }
    }
}
