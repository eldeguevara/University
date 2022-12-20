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
    }
}
