using Microsoft.EntityFrameworkCore;
using Wishlist.Domain.Client;
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

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}
