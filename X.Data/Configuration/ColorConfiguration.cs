using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable(nameof(Color));

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ProductDetail).WithOne(x => x.Color).HasForeignKey<ProductDetail>(x => x.ColorId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}