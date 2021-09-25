using Microsoft.EntityFrameworkCore;
using One_to_One.Data.Models;

namespace StudentAddress.Data
{
    public class StudentAddressContext : DbContext
    {
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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OneToZeroOrOne");

        }
    }
}
