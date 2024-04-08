using Microsoft.EntityFrameworkCore;
using Waffar.Models;
using Waffar.EntityConfigurations;

namespace Waffar.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new BalanceConfiguration());
            modelBuilder.ApplyConfiguration(new BillConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DiaryConfiguration());
            // modelBuilder.ApplyConfiguration(new MapperConfigurations() );
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new TipsAndTricksConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Diary> Diary { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TipsAndTricks> TipsAndTricks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
