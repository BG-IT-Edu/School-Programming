using Microsoft.EntityFrameworkCore;
using One_to_Many.Data.Models;

namespace One_to_Many.Data
{
    public class One_to_ManyContext : DbContext
    {
        public One_to_ManyContext()
        {
        }
        public One_to_ManyContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GradeId);

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
