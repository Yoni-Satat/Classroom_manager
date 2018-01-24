using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
