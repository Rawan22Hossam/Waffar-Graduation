using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class TipsAndTricksConfiguration : IEntityTypeConfiguration<TipsAndTricks>
    {
        public void Configure(EntityTypeBuilder<TipsAndTricks> builder)
        {
            builder.HasKey(t => t.TipsId);
            builder.Property(t => t.TipsAndTricksText);
        }
    }
}
