using System.ComponentModel.DataAnnotations;

namespace Yien_Express.Model
{
    public class Employee
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
