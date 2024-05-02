using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;

namespace MovieTicket.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Bookings { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
