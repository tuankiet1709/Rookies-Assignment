using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.ProductId).IsRequired();
            builder.Property(c => c.Quantity).HasDefaultValue(1);
            builder.Property(c => c.Price).IsRequired();

            builder.HasOne(x=>x.Product).WithMany(x=>x.Carts).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.User).WithMany(x=>x.Carts).HasForeignKey(x=>x.UserId);
        }
    }
}
