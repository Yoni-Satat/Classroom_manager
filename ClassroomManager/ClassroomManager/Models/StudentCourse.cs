using System;
namespace ClassroomManager.Models
{
    public class StudentCourse
    {
        public int ID { get; set; }
        public int studentID { get; set; }
        public Student student { get; set; }
        public int courseID { get; set; }
        public Course course { get; set; }
    }
}
