using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Name).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(200).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Message).IsRequired();
            builder.Property(b => b.Status).HasDefaultValue(Status.Active);
        }
    }
}
