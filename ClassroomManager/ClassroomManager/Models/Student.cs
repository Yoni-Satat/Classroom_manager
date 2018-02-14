using System;
namespace ClassroomManager.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string matricNumber { get; set; }
        public string gender { get; set; }
        public bool adjustments { get; set; }
        public string origin { get; set; }
        public int yearOfStudy { get; set; }
        public string imageURL { get; set; }
    }
}
