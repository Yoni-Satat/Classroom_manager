using System;
using ClassroomManager.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}
