using System;
using ClassroomManager.Data;
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
    }
}
