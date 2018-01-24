using System;
namespace ClassroomManager.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string title { get; set; }
        public int level { get; set; }
        public string courseUniId { get; set; }
        public int numberOfLessons { get; set; }

    }
}
