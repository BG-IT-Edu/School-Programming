using System;
using System.Collections.Generic;
using System.Text;

namespace One_to_Many.Data.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students => new List<Student>();
    }
}
