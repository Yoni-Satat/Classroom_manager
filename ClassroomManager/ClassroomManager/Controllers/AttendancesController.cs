using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomManager.Data;
using ClassroomManager.Models;
using Microsoft.AspNetCore.Mvc;

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
        public void Get() {
            //return CMContext.Attendances.ToList();
        }
    }
}
