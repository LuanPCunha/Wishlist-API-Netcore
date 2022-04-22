using Microsoft.EntityFrameworkCore;
using Wishlist.Domain.Product;
using Wishlist.Domain.User;
using Wishlist.Domain.UserProductList;

namespace Wishlist.Infrastructure.Persistence.Core
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProductList> UserProductList { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }

    }
}
