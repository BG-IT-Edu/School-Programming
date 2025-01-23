using System;
using System.Collections.Generic;
using System.Text;

namespace Many_to_Many.Data.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}
