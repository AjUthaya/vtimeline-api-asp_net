using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace vtimeline
{
    public partial class DatabaseController : DbContext
    {
        // DEFINE: Variable
        public virtual DbSet<userModel> Users { get; set; }

        // CONFIGURE: Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. IF: Already configured
            if (!optionsBuilder.IsConfigured)
            {
                // A. DEFINE: Database connection string
                optionsBuilder.UseMySQL("server=localhost;port=8889;user=root;password=root;database=sample");
            }
        }

        // CONFIGURE: Database models
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. DEFINE: Entity Framework version
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            // 2. MODEL: Users table
            modelBuilder.Entity<userModel>(entity =>
            {
                entity.ToTable("users", "sample");

                entity.HasIndex(e => e.Id)
                    .HasName("id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
