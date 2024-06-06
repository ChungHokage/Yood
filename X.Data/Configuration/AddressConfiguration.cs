using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(nameof(Address));
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Addresses).HasForeignKey(x => x.UserId);

            builder.Property(x => x.Province).HasMaxLength(100);
            builder.Property(x => x.Commune).HasMaxLength(100);
            builder.Property(x => x.District).HasMaxLength(100);

            builder.Property(x => x.isDefault).HasDefaultValue(false);
        }
    }
}