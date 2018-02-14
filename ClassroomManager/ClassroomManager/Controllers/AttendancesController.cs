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
    public class AttendancesController : Controller
    {
        public CMContext CMContext { get; set; }

        public AttendancesController(CMContext cmContext)
        {
            CMContext = cmContext;
        }
        [HttpGet]
        public IEnumerable<Attendance> Get() {
            return CMContext.Attendances.ToList();
        }

        [HttpPost]
        public Attendance Post([FromBody] Attendance attendance) {
            CMContext.Attendances.Add(attendance);
            CMContext.SaveChanges();
            return attendance;
        }

        [HttpGet("{id}")]
        public Attendance Get(int id) {
            var foundAttendance = CMContext.Attendances
                                           .Include((attendance) => attendance.student)
                                           .Include((attendance) => attendance.lesson)
                                           .Include((attendance) => attendance.course)
                                           .Include((attendance) => attendance.reason)
                                           .Where((attendance) => id == attendance.ID)
                                           .FirstOrDefault();
            return foundAttendance;
        }

        [HttpPut("{id}")]
        public Attendance Put(int id, [FromBody] Attendance updatedAttendance) {
            var foundAttendance = CMContext.Attendances.Where((attendance) => id == attendance.ID)
                                           .FirstOrDefault();
            foundAttendance.studentID = updatedAttendance.studentID;
            foundAttendance.lessonID = updatedAttendance.lessonID;
            foundAttendance.courseID = updatedAttendance.courseID;
            foundAttendance.reasonID = updatedAttendance.reasonID;
            foundAttendance.present = updatedAttendance.present;
            CMContext.SaveChanges();
            return foundAttendance;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var foundAttendance = CMContext.Attendances.Where((attendance) => id == attendance.ID)
                                           .FirstOrDefault();
            CMContext.Attendances.Remove(foundAttendance);
            CMContext.SaveChanges();
            return NoContent();
        }
    }
}
