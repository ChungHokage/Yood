using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail));
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetail).HasForeignKey(x => x.OrderId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Quanity).HasDefaultValue(0);
        }
    }
}