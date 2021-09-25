using System;
using System.Collections.Generic;
using System.Text;

namespace Many_to_Many.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }

    }
}
