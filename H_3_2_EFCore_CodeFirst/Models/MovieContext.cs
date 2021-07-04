using Microsoft.EntityFrameworkCore;

namespace H_3_2_EFCore_CodeFirst.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Commets { get; set; }
    }
}
