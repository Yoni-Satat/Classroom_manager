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

        [HttpGet("{id}")]
        public Course Get(int id)
        {
            var foundCourse = CMContext
                .Courses
                .Where((course) => id == course.ID).FirstOrDefault();
            return foundCourse;
        }


        [HttpPut("{id}")]
        public Course Put(int id, [FromBody] Course updatedCourse)
        {
            var foundCourse = CMContext
                .Courses
                .Where((course) => id == course.ID).FirstOrDefault();
            foundCourse.title = updatedCourse.title;
            foundCourse.level = updatedCourse.level;
            foundCourse.courseUniId = updatedCourse.courseUniId;
            foundCourse.numberOfLessons = updatedCourse.numberOfLessons;
            CMContext.SaveChanges();
            return foundCourse;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foundCourse = CMContext
                .Courses
                .Where((course) => id == course.ID).FirstOrDefault();
            CMContext.Courses.Remove(foundCourse);
            CMContext.SaveChanges();
            return NoContent();
        }


    }
}
