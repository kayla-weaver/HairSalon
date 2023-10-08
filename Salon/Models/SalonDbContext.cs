using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
    public class SalonDbContext : DbContext
    {
        public virtual DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client>  Clients { get; set; }
        public cd SalonDbContext(DbContextOptions options) : base(options) { }
    }
}