using System.ComponentModel.DataAnnotations;

namespace Yien_Express.DTO
{
    public class UserCreateDTO
    {
        [Required]
        public string? userType { get; set; }
        [Required]
        public string? userName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
