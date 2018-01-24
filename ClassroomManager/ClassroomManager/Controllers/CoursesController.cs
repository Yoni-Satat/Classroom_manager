using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManager.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        public CMContext CMContext { get; set; }

        public CoursesController(CMContext cmContext)
        {
            CMContext = cmContext;
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return CMContext.Courses.ToList();
        }

        [HttpPost]
        public Course Post([FromBody] Course course)
        {
            CMContext.Courses.Add(course);
            CMContext.SaveChanges();
            return course;
        }



    }
}
