using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManager.Controllers
{
    [Route("api/[controller]")]
    public class StudentCoursesController : Controller
    {
       
        public CMContext CMContext { get; set; }

        public StudentCoursesController(CMContext cmContext)
        {
            CMContext = cmContext;
        }

        [HttpGet]
        public IEnumerable<StudentCourse> Get()
        {
            return CMContext.StudentCourses.ToList();
        }

    }
}
