using Microsoft.EntityFrameworkCore;
using One_to_One.Data.Models;

namespace One_to_One.Data
{
    public class One_to_OneContext : DbContext
    {
        public One_to_OneContext()
        {
        }
        public One_to_OneContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Student)
                .WithOne(s => s.Address)
                .HasForeignKey<Address>(a => a.StudentId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.stringConfiguration);
            }
        }
    }
}
