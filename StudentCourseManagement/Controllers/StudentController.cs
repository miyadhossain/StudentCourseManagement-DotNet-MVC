using StudentCourseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCourseManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // Sample Data
            var teacher1 = new Teacher { TeacherId = 1, Name = "John Doe" };
            var teacher2 = new Teacher { TeacherId = 2, Name = "Jane Smith" };

            var course1 = new Course { CourseId = 1, CourseName = "Math", TeacherId = 1, Teacher = teacher1 };
            var course2 = new Course { CourseId = 2, CourseName = "Physics", TeacherId = 2, Teacher = teacher2 };

            var students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Alice", CourseId = 1, Course = course1 },
                new Student { StudentId = 2, Name = "Bob", CourseId = 2, Course = course2 }
            };

            return View(students);
        }
    }
}