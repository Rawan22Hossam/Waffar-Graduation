using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(t => t.BillId);
            builder.Property(t => t.BillName).IsRequired();
            builder.Property(t => t.BillDueDate);
            builder.Property(t => t.BillDescription).IsRequired();
        }
    }
}
