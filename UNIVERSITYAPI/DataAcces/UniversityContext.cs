using Microsoft.EntityFrameworkCore;
using UNIVERSITYAPI.Models.DataModels;

namespace UNIVERSITYAPI.DataAcces
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }

        //db sets table database
        public DbSet<Users>? Users { get; set; }
        public DbSet<Course>? Courses { get; set;}
        public DbSet<Chapters>? Chapters { get; set; }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        


    }
}
