using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wishlist.Domain.UserProductList;

namespace Wishlist.Infrastructure.Persistence.Mapping
{
    public class UserProductListMap : IEntityTypeConfiguration<UserProductList>
    {
        public void Configure(EntityTypeBuilder<UserProductList> builder)
        {
            builder.ToTable("UserProductList");
            builder.Property(p => p.UserId). IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
        }
    }
}
