using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManager.Controllers
{
    [Route("api/[controller]")]
    public class LessonsController : Controller
    {
        public CMContext CMContext { get; set; }

        public LessonsController(CMContext cmContext)
        {
            CMContext = cmContext;
        }

        [HttpGet]
        public IEnumerable<Lesson> Get() {
            return CMContext.Lessons.ToList();
        }

        [HttpPost]
        public Lesson Post([FromBody] Lesson lesson)
        {
            CMContext.Lessons.Add(lesson);
            CMContext.SaveChanges();
            return lesson;
        }

        [HttpGet("{id}")]
        public Lesson Get(int id) {
            var foundLesson = CMContext
                .Lessons
                .Include((lesson) => lesson.course)
                .Where((lesson) => id == lesson.ID).FirstOrDefault();
            return foundLesson;
        }

        [HttpPut("{id}")]
        public Lesson Put(int id, [FromBody] Lesson updatedLesson)
        {
            var foundLesson = CMContext
                .Lessons
                .Where((lesson) => id == lesson.ID).FirstOrDefault();

            foundLesson.topic = updatedLesson.topic;
            foundLesson.startTime = updatedLesson.startTime;
            foundLesson.endTime = updatedLesson.endTime;
            foundLesson.isMandatory = updatedLesson.isMandatory;
            foundLesson.index = updatedLesson.index;
            foundLesson.location = updatedLesson.location;


            CMContext.SaveChanges();

            return foundLesson;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foundLesson = CMContext
                .Lessons
                .Where((lesson) => id == lesson.ID).FirstOrDefault();
            CMContext.Lessons.Remove(foundLesson);
            CMContext.SaveChanges();
            return NoContent();
        }


    }
}
