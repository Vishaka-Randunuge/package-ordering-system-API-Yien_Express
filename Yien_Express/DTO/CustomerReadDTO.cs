using System.ComponentModel.DataAnnotations;

namespace Yien_Express.DTO
{
    public class CustomerReadDTO
    {
        public int ID { get; set; }
        
        public string? Name { get; set; }
        
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
