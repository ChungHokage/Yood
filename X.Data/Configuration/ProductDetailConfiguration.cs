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
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable(nameof(ProductDetail));
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.Product).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.QuanityRemaining).HasDefaultValue(0);
            builder.Property(x => x.QuanitySold).HasDefaultValue(0);
        }
    }
}