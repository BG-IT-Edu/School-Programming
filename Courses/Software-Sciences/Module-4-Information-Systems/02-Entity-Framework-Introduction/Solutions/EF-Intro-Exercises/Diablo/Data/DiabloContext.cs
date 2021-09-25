using System;
using Diablo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Diablo.Data
{
    public partial class DiabloContext : DbContext
    {
        public DiabloContext()
        {
        }

        public DiabloContext(DbContextOptions<DiabloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<GameTypeForbiddenItem> GameTypeForbiddenItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGameItem> UserGameItems { get; set; }
        public virtual DbSet<UsersGame> UsersGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Diablo;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Character>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Statistic)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.StatisticId)
                    .HasConstraintName("FK_Characters_Statistics");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.GameType)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GameTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_GameTypes");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BonusStats)
                    .WithMany(p => p.GameTypes)
                    .HasForeignKey(d => d.BonusStatsId)
                    .HasConstraintName("FK_GameTypes_Statistics");
            });

            modelBuilder.Entity<GameTypeForbiddenItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.GameTypeId });

                entity.HasOne(d => d.GameType)
                    .WithMany(p => p.GameTypeForbiddenItems)
                    .HasForeignKey(d => d.GameTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameTypeForbiddenItems_GameTypes");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.GameTypeForbiddenItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameTypeForbiddenItems_Items");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_ItemTypes");

                entity.HasOne(d => d.Statistic)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.StatisticId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Statistics");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserGameItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.UserGameId });

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.UserGameItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGameItems_Items");

                entity.HasOne(d => d.UserGame)
                    .WithMany(p => p.UserGameItems)
                    .HasForeignKey(d => d.UserGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGameItems_UsersGames");
            });

            modelBuilder.Entity<UsersGame>(entity =>
            {
                entity.Property(e => e.Cash)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.JoinedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Characters");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Games");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Users1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
