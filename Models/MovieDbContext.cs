using Microsoft.EntityFrameworkCore;

namespace Movie_HandsOn.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<MovieModel> movieModels { get; set; }
    }
}
