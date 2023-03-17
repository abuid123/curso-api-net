using MiBackendCampus.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace MiBackendCampus.DataAccess
{
    public class UniversityDBContext : DbContext
    {

        public UniversityDBContext( DbContextOptions<UniversityDBContext> option) : base(option) { }
        
        public DbSet<User>? Users { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Chapter>? Chapters { get; set; }
    }
}
