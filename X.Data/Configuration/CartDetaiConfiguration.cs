using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class CartDetaiConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Cart).WithMany(x => x.CartDetails).HasForeignKey(x => x.CartId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Product).WithMany(x => x.CartDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Quanity).HasDefaultValue(0);
            builder.Property(x => x.Price).HasDefaultValue(0);
        }
    }
}