using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable(nameof(AppUser));
            builder.HasOne(x => x.UserInformation).WithOne(x => x.AppUser).HasForeignKey<UserInformation>(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.DisplayName).HasMaxLength(150).HasDefaultValue("Customer");
        }
    }
}