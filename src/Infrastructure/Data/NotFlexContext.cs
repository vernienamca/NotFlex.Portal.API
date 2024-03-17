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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>(ConfigureCategory);
            builder.Entity<Movie>(ConfigureMovie);
            builder.Entity<MovieCategory>(ConfigureMovieCategory);
        }

        private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.Property(e => e.CreatedBy)
                .IsRequired(true);

            builder.Property(e => e.DateCreated)
                .IsRequired(true)
                .HasColumnType("datetime");

            builder.Property(e => e.UpdatedBy)
                .IsRequired(false);

            builder.Property(e => e.DateUpdated)
                .IsRequired(false)
                .HasColumnType("datetime");
        }

        private void ConfigureMovie(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Title)
                .IsRequired(true)
                .HasMaxLength(250);

            builder.Property(e => e.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(e => e.GroupName)
                .IsRequired(true)
                .HasMaxLength(25);

            builder.Property(e => e.ReleasedDate)
                .IsRequired(true)
                .HasColumnType("datetime");

            builder.Property(e => e.Director)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(e => e.DistributedBy)
              .IsRequired(true)
              .HasMaxLength(50);

            builder.Property(e => e.Length)
                .IsRequired(true)
                .HasMaxLength(15);

            builder.Property(e => e.PosterImage)
                .IsRequired(true)
                .HasMaxLength(250);

            builder.Property(e => e.IsFeature)
                .IsRequired(true);

            builder.Property(e => e.CreatedBy)
                .IsRequired(true);

            builder.Property(e => e.DateCreated)
                .IsRequired(true)
                .HasColumnType("datetime");

            builder.Property(e => e.UpdatedBy)
                .IsRequired(false);

            builder.Property(e => e.DateUpdated)
                .IsRequired(false)
                .HasColumnType("datetime");
        }

        private void ConfigureMovieCategory(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.ToTable("MovieCategory");

            builder.HasKey(x => new { x.MovieId, x.CategoryId });
        }
    }
}
