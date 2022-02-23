using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ToTable("Discounts");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn();
            builder.Property(d => d.Name).IsRequired();
            builder.Property(d => d.FromDate).IsRequired();
            builder.Property(d => d.ToDate).IsRequired();
            builder.Property(d => d.LimitedOrderPrice).HasDefaultValue(0);
            builder.Property(d => d.ApplyAll).HasDefaultValue(true);
            builder.Property(d => d.DiscountPercent).IsRequired();
            builder.Property(d => d.DiscountAmount).IsRequired();
            builder.Property(d => d.Status).HasDefaultValue(Status.InActive);
        }
    }
}
