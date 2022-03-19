using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Backend.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Ratings");
            builder.HasKey(r => r.RateId);
            builder.Property(r => r.RateId).UseIdentityColumn();
            builder.Property(r => r.RateDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(r => r.RatePoint).IsRequired();
            builder.Property(r => r.ReviewerName).IsRequired();
            builder.Property(r => r.Comment).HasMaxLength(200);
            builder.Property(r => r.IsApproved).HasDefaultValue(false);
            builder.Property(r => r.IsDelete).HasDefaultValue(false);

            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductRatings).HasForeignKey(x=>x.ProductId);

        }
    }
}
