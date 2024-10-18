using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourseManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}