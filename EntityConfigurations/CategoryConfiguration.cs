using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t => t.CategoryId);
            builder.Property(t => t.ItemValue).IsRequired();
            builder.Property(t => t.ItemName).IsRequired();
            builder.Property(t => t.LimitValue);
            builder.Property(t => t.CategoryName).IsRequired();
        }
    }
}
