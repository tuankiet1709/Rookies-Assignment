using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c=>c.CreatedDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(c=>c.IsShowOnHome).HasDefaultValue(IsShowOnHome.Show);
            builder.Property( c=> c.Status).HasDefaultValue(Status.Active);

            
        }
    }
}
