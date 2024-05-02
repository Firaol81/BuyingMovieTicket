using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace MovieTicket.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
               .Ignore(m => m.Showtimes);
        }
    }
}