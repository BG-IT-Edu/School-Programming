using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.HomeworkSubmissions = new HashSet<Homework>();
            this.CourseEnrollments = new HashSet<StudentCourse>();
        }
        public int StudentId { get; set; }

        // Name (up to 100 characters, unicode)
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // PhoneNumber(exactly 10 characters, not unicode, not required)
        [Column(TypeName = "char(10)")]
        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        // Birthday(not required) - nullable
        public DateTime? Birthday { get; set; }

        public ICollection<Homework> HomeworkSubmissions{ get; set; }

        public ICollection<StudentCourse> CourseEnrollments { get; set; }

    }
}
