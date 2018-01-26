using System;
using ClassroomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManager.Data
{
    public class CMContext : DbContext
    {
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public CMContext(DbContextOptions<CMContext> options) : base(options) {
            
        }
    }
}