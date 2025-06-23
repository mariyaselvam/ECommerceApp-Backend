using Microsoft.EntityFrameworkCore;
using ECommerceApp.Models.User;
using ECommerceApp.Models.Product;

namespace ECommerceApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
