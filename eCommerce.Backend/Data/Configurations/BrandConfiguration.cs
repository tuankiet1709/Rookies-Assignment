using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.Name).IsRequired();
            builder.Property( b=> b.Status).HasDefaultValue(Status.Active);
        }
    }
}
