using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Backend.Configurations{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p=>p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p=>p.CreatedDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(p=>p.OriginalPrice).IsRequired();
            builder.Property(p=>p.Price).IsRequired();
            builder.Property(p=>p.Images).IsRequired(false);
            builder.Property(p=>p.Stock).HasDefaultValue(0);
            builder.Property(p=>p.ViewCount).HasDefaultValue(0);
            builder.Property(x => x.Details).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.isDeleted).HasDefaultValue(false);
            builder.Property(x=>x.IsFeatured).HasDefaultValue(false);
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.BrandId).IsRequired();

            builder.HasOne(x=>x.Brand).WithMany(x=>x.Products).HasForeignKey(x=>x.BrandId);
            builder.HasOne(x=>x.Category).WithMany(x=>x.Products).HasForeignKey(x=>x.CategoryId);

        }
    }
}
