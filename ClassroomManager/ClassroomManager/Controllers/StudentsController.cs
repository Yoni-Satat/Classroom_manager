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

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var foundStudent = CMContext
                .Students
                .Where((student) => id == student.ID).FirstOrDefault();
            return foundStudent;
        }


        [HttpPut("{id}")]
        public Student Put(int id, [FromBody] Student updatedStudent)
        {
            var foundStudent = CMContext
                .Students
                .Where((student) => id == student.ID).FirstOrDefault();
            
            foundStudent.firstName = updatedStudent.firstName;
            foundStudent.lastName = updatedStudent.lastName;
            foundStudent.DateOfBirth = updatedStudent.DateOfBirth;
            foundStudent.matricNumber = updatedStudent.matricNumber;
            foundStudent.gender = updatedStudent.gender;
            foundStudent.adjustments = updatedStudent.adjustments;
            foundStudent.origin = updatedStudent.origin;
            foundStudent.yearOfStudy = updatedStudent.yearOfStudy;

            CMContext.SaveChanges();

            return foundStudent;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foundStudent = CMContext
                .Students
                .Where((student) => id == student.ID).FirstOrDefault();
            CMContext.Students.Remove(foundStudent);
            CMContext.SaveChanges();
            return NoContent();
        }



    }
}
