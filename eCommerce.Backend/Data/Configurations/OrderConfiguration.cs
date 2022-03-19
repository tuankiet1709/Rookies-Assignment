using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(p => p.OrderDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(o => o.ShipName).HasMaxLength(200).IsRequired();
            builder.Property(o => o.ShipAddress).HasMaxLength(200).IsRequired();
            builder.Property(o => o.ShipEmail).HasMaxLength(200).IsRequired();
            builder.Property(o => o.ShipPhoneNumber).IsRequired();
            builder.Property(o => o.Status).HasDefaultValue(OrderStatus.InProgress);

            builder.HasOne(x=>x.User).WithMany(x=>x.Orders).HasForeignKey(x=>x.UserId);

        }
    }
}
