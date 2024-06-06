using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TotalValue).HasDefaultValue(0);
            builder.Property(x => x.TotalPrice).HasDefaultValue(0);
            builder.Property(x => x.Promotion).HasDefaultValue(0);
            builder.Property(x => x.TransportFee).HasDefaultValue(0);
        }
    }
}