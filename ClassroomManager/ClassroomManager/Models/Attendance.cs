using System;
namespace ClassroomManager.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public int lessonID { get; set; }
        public Lesson lesson { get; set; }
        public int studentID { get; set; }
        public Student student { get; set; }
        public int courseID { get; set; }
        public Course course { get; set; }
        public bool present { get; set; }
        public int reasonID { get; set; }
        public Absence reason { get; set; }
    }
}
