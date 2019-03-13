using System.ComponentModel.DataAnnotations;

namespace FailView.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
