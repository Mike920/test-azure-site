using System.Data.Entity;

namespace ASP_Tut.Models
{
    //Connection string
    public class MovieDBContext : DbContext
    {
        public MovieDBContext()
            : base("DefaultConnection")
        {}

        public DbSet<Movie> Movies { get; set; }
    }
}