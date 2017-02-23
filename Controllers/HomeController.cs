using System.Collections.Generic;
using ConsoleApplication.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Student> students = new List<Student>();
            students.Add(new Student("Claus", 34));
            students.Add(new Student("Clausfdsdfs", 34));
            students.Add(new Student("Claussdfsdfsdfdsfds", 34));


            ViewBag.Y = students;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
