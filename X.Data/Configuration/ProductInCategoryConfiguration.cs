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
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable(nameof(ProductInCategory));
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}