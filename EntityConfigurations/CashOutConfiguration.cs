using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class CashOutConfiguration : IEntityTypeConfiguration<CashOutTransaction>
    {
        public void Configure(EntityTypeBuilder<CashOutTransaction> builder)
        {
            builder.HasKey(t => t.TransactionId);
            builder.Property(t => t.Description).IsRequired();
            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.Date).IsRequired();

        }
    }
}
