using System.ComponentModel.DataAnnotations;
using Yien_Express.Model;

namespace Yien_Express.DTO
{
    public class OrderReadDTO
    {

        public int Id { get; set; }

        public string? packageName { get; set; }

        public int quantity { get; set; }

        public string? cName { get; set; }
      
        public string? cPhone { get; set; }
        public String? orderDate { get; set; }
        

        public String? DeliveryDate { get; set; }

        public string? Description { get; set; }

        
        public string? location { get; set; }

        public string? tracking { get; set; }
    }
}
