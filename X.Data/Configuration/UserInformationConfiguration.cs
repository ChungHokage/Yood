using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class UserInformationConfiguration : IEntityTypeConfiguration<UserInformation>
    {
        public void Configure(EntityTypeBuilder<UserInformation> builder)
        {
            builder.ToTable("UserInformation");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fullname).HasMaxLength(128);
        }
    }
}