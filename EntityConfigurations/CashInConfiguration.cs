using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class CashInConfiguration : IEntityTypeConfiguration<CashInTransaction>
    {
        public void Configure(EntityTypeBuilder<CashInTransaction> builder)
        {
            builder.HasKey(t => t.TransactionId);
            builder.Property(t => t.Description).IsRequired();
            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.Date).IsRequired();

        }
    }
}
