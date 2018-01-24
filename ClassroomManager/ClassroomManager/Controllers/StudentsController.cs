using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManager.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        public CMContext CMContext { get; set; }

        public StudentsController(CMContext cmContext)
        {
            CMContext = cmContext;
        }

        [HttpGet]
        public IEnumerable<Student> Get() {
            return CMContext.Students.ToList();
        }

        [HttpPost]
        public Student Post([FromBody] Student student) {
            CMContext.Students.Add(student);
            CMContext.SaveChanges();
            return student;
        }


    }
}
