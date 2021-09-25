using Many_to_Many.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Many_to_Many.Data
{
    public class Many_to_ManyContext : DbContext
    {
        public Many_to_ManyContext()
        {
        }
        public Many_to_ManyContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
              .HasOne(sc => sc.Student)
              .WithMany(s => s.StudentsCourses)
              .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
              .HasOne(sc => sc.Course)
              .WithMany(s => s.StudentsCourses)
              .HasForeignKey(sc => sc.CourseId);


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
