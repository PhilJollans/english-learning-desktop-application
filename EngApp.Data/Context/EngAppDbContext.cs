using EngApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace EngApp.Data.Context
{
    public class EngAppDbContext : DbContext
    {
        public EngAppDbContext()
        {
        }

        public EngAppDbContext(DbContextOptions<EngAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // appsettings.json dosyasından bağlantı dizesini oku
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("EngAppDb");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>(entity =>
            {
                entity.Property(x => x.Text)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.Meaning)
                      .IsRequired()
                      .HasMaxLength(300);

                entity.Property(x => x.MySentence)
                      .HasMaxLength(500);

                entity.Property(x => x.Note)
                      .HasMaxLength(300);

                entity.Property(x => x.PartOfSpeech)
                      .IsRequired()
                      .HasMaxLength(50)
                      .HasDefaultValue("Unknown");

                // Removed unique index to allow same word with different PartOfSpeech
                // UI handles duplicate checking for Text + PartOfSpeech combination
            });
        }
    }
}
