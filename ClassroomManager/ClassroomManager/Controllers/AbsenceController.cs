using System;
using System.Collections.Generic;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
