using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wishlist.Domain.Product;

namespace Wishlist.Infrastructure.Persistence.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("varchar(300)").IsRequired();
            builder.Property(p => p.ValorDeVenda).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(p => p.Nome).HasColumnType("nvarchar(max)");
        }
    }
}
