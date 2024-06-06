using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using X.Data.Entities;

namespace X.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).HasMaxLength(100);
            builder.Property(x => x.SeoTitle).HasMaxLength(100);
            builder.Property(x => x.SeoAlias).HasMaxLength(100);
            builder.Property(x => x.ParentId).HasDefaultValue(null);
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.SeoDescription).HasMaxLength(100);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
        }
    }
}