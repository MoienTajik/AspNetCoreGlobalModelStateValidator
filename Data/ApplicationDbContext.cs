using FailView.Models;
using Microsoft.EntityFrameworkCore;

namespace FailView.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}