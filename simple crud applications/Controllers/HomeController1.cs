using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simple_crud_applications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_applications.Controllers
{
    public class HomeController1 : Controller
    {
        StudentDbContext db;
        private StudentDbContext dbContext;
        public HomeController1(StudentDbContext context)
        {
            this.dbContext = context;
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Student ampob)
        {
            db.Students.Add(ampob);
            db.SaveChanges();
            return View();
        }
    }
}
