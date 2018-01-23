using System;
using ClassroomManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManager.Data
{
    public class CMContext : DbContext
    {
        public DbSet<Absence> Absences { get; set; }
        public CMContext(DbContextOptions<CMContext> options) : base(options) {
            
        }
    }
}