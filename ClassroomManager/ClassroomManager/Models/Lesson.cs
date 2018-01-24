using System;
namespace ClassroomManager.Models
{
    public class Lesson
    {
        public int ID { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isMandatory { get; set; }
        public int index { get; set; }
        public string location { get; set; }
        public int CourseID { get; set; }
        public Course course { get; set; }
    }
}
