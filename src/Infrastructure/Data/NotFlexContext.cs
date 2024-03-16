using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotFlex.ApplicationCore.Entities.Structure;

namespace NotFlex.Infrastructure.Data
{
    public class NotFlexContext : DbContext
    {
        public NotFlexContext(DbContextOptions<NotFlexContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>(ConfigureCategory);
        }

        private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(150);
        }
    }
}
