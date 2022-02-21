using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Backend.Configurations{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(pc => new {pc.CategoryId, pc.ProductId});

            builder.HasOne(pc => pc.Products)
            .WithMany(p=>p.ProductCategories)
            .HasForeignKey(pc=>pc.ProductId);

            builder.HasOne(pc => pc.Categories)
            .WithMany(c=>c.ProductCategories)
            .HasForeignKey(pc=>pc.CategoryId);
        }
    }
}
