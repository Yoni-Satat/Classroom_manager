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
    public class AbsenceController : Controller
    {
        public CMContext CMContext { get; set; }

        public AbsenceController(CMContext cmContext)
        {
            CMContext = cmContext;
        }

        [HttpGet]
        public IEnumerable<Absence> Get() {
            return CMContext.Absences.ToList();
        }

        [HttpPost]
        public Absence Post([FromBody] Absence reason) {
            CMContext.Absences.Add(reason);
            CMContext.SaveChanges();
            return reason;
        }

        [HttpGet("{id}")]
        public Absence Get(int id) {
            var foundReason = CMContext
                .Absences
                .Where((reason) => id == reason.ID).FirstOrDefault();
            return foundReason;
        }

        [HttpPut("{id}")]
        public Absence Put(int id, [FromBody] Absence updatedAbsence) {
            var foundReason = CMContext
                .Absences
                .Where((reason) => id == reason.ID).FirstOrDefault();
            foundReason.Reason = updatedAbsence.Reason;
            CMContext.SaveChanges();
            return foundReason;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foundReason = CMContext
                .Absences
                .Where((reason) => id == reason.ID).FirstOrDefault();
            CMContext.Absences.Remove(foundReason);
            CMContext.SaveChanges();
            return NoContent();
        }

    }
}
