
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wishlist.Domain.User;

namespace Wishlist.Infrastructure.Persistence.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("Text(50)");
            builder.Property(p => p.Email).HasColumnType("Text(50)").IsRequired();
            builder.Property(p => p.PasswordSalt).HasColumnType("Bytea").IsRequired();
            builder.Property(p => p.PasswordHash).HasColumnType("Bytea").IsRequired();
        }
    }
}
