﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost]
        public StudentCourse Post([FromBody] StudentCourse studentCourse)
        {
            CMContext.StudentCourses.Add(studentCourse);
            CMContext.SaveChanges();
            return studentCourse;
        }

        [HttpGet("{id}")]
        public StudentCourse Get(int id)
        {
            var foundStudentCourse = CMContext
                .StudentCourses
                .Include((studentCourse) => studentCourse.course)
                .Include((studentCourse) => studentCourse.student)
                .Where((studentCourse) => id == studentCourse.ID).FirstOrDefault();
            return foundStudentCourse;
        }

    }
}
