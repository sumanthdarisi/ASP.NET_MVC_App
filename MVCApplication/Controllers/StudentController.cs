using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student> {
                new Student() { Student_ID = 1, Student_Name = "Sumanth", Student_Age = 28 },
                new Student() { Student_ID = 2, Student_Name = "Sowmya", Student_Age = 25 }
                };

        // GET: Student
        [ActionName("StudentsList")]
        public ActionResult Index()
        {
            return View(students);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = students.Where(c => c.Student_ID.Equals(id)).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var id = std.Student_ID;
            var name = std.Student_Name;
            var age = std.Student_Age;

            return RedirectToAction("StudentsList");
        }

        public ActionResult Details(int id)
        {
            var std = students.Where(c => c.Student_ID.Equals(id)).FirstOrDefault();
            return View(std);
        }


        //public ActionResult Details(int id)


    }
}