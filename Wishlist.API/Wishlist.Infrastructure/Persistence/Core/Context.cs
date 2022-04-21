using Microsoft.EntityFrameworkCore;
using Wishlist.Domain.Product;
using Wishlist.Domain.User;

namespace Wishlist.Infrastructure.Persistence.Core
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.UseSerialColumns();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
