namespace P01_StudentSystem.Data.Models
{
    public class StudentCourse
    {
        public int CourseId { get; set; }

        public Course Course { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }


    }
}
