using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
    {

        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.HasKey(t => t.BalanceId);
            builder.Property(t => t.MoneySpent).IsRequired();
            builder.Property(t => t.Savings).IsRequired();
            builder.Property(t => t.Income).IsRequired();
        }

    }
}
