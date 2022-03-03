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
            builder.Property(p=>p.DateCreated).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoDescription).HasMaxLength(500);
            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property( b=> b.Status).HasDefaultValue(Status.Active);

            
        }
    }
}
