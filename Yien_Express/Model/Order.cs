using System.ComponentModel.DataAnnotations;

namespace Yien_Express.Model
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? packageName { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string? cName { get; set; }
        [Required]
        public string? cPhone { get; set; }
        public String? orderDate { get; set; }
        [Required]
        public String? DeliveryDate { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? location { get; set; }
        public string? tracking { get; set; }
    }
}
