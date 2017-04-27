using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class StudentController : Controller 
    {
        MyDbContext db = new MyDbContext();
        // Index
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(st);
                 db.SaveChanges();
                 return RedirectToAction("Index");

            } else 
            {
                return View();
            }
            
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id) {
            Student student = db.Students.Find(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(Student st) {
            //Student student = db.Students.Find(st.StudentID);
            db.Students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Update
        public IActionResult Update(Student st){
            
        }

        //Read?
    }
}