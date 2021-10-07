using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MidtermAngularProject.Models
{
    public partial class StudyBuddyDBContext : DbContext
    {
        public StudyBuddyDBContext()
        {
        }

        public StudyBuddyDBContext(DbContextOptions<StudyBuddyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                optionsBuilder.UseSqlServer("Server=(LocalDb)\\LocalDB;Database=StudyBuddyDB;Trusted_Connection=true;MultipleActiveResultSets=true");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.AnswerText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Favorites__Quest__286302EC");
                    .HasConstraintName("FK__Favorites__Quest__276EDEB3");


                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.UserId)

                    .HasConstraintName("FK__Favorites__UserI__29572725");
                    .HasConstraintName("FK__Favorites__UserI__286302EC");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.AnswerText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {

                entity.Property(e => e.UserId).HasColumnName("UserID");


                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
