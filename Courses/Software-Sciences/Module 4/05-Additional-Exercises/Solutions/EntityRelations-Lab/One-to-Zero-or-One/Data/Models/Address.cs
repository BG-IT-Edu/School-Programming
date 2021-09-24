using System.ComponentModel.DataAnnotations.Schema;

namespace One_to_One.Data.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Text { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
