//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Wishlist.Domain.Client;

//namespace Wishlist.Infrastructure.Persistence.Mapping
//{
//    public class ClientMap : IEntityTypeConfiguration<Client>
//    {
//        public void Configure(EntityTypeBuilder<Client> builder)
//        {
//            builder.ToTable("Client");
//            builder.HasKey(p => p.Id);
//            builder.Property(p => p.ProductId).HasColumnType("uuid");
//        }
//    }
//}
