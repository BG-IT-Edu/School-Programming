using Microsoft.EntityFrameworkCore;
using MusicProvider.Data.Models;

namespace MusicProvider.Data
{
    public class MusicProviderContext : DbContext
    {
        public MusicProviderContext()
        {
        }
        public MusicProviderContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistsSongs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AuthorBook>()
            //    .HasKey(k => new { k.AuthorId, k.BookId });


            modelBuilder.Entity<Playlist>()
                .HasOne(u => u.User)
                .WithMany(p => p.Playlists);

            modelBuilder.Entity<PlaylistSong>()
                .HasKey(ps => new { ps.PlaylistId, ps.SongId });

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(p => p.Playlist)
                .WithMany(ps => ps.PlaylistsSongs)
                .HasForeignKey(ps => ps.PlaylistId);

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(s => s.Song)
                .WithMany(ps => ps.PlaylistsSongs)
                .HasForeignKey(ps => ps.SongId);

        }
    }
}
