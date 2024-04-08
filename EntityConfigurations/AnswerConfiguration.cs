using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(t => t.AnswerId);
            builder.Property(t => t.AnswerDescription).IsRequired();
            // foreign key to userid

        }
    }
}
