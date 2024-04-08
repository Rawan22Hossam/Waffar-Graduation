using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waffar.Models;

namespace Waffar.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.UserId);
            builder.Property(t => t.UserName).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.MaritialState).IsRequired();
            builder.Property(t => t.Gender).IsRequired();
            builder.Property(t => t.Phone).IsRequired();
            builder.Property(t => t.Password).IsRequired();
        }
    }
}
