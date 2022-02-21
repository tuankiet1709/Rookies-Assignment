using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Backend.Configurations
{
    public class RateConfiguration : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.ToTable("Rates");
            builder.HasKey(r => r.RateId);
            builder.Property(r => r.RateId).UseIdentityColumn();
            builder.Property(r => r.RateDate).IsRequired().HasDefaultValueSql("GetDate())");
            builder.Property(r => r.RatePoint).IsRequired();
            builder.Property(r => r.IsApproved).HasDefaultValue(false);
            builder.Property(r => r.IsDelete).HasDefaultValue(false);

            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductRates).HasForeignKey(x=>x.ProductId);

        }
    }
}
