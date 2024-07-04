using api.Models.Entities;
using JwtRoleAuthentication.Enums;
using System.ComponentModel.DataAnnotations;

namespace Jwt.Models.Dtos
{
    public class Register
    {
        public int Id { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Email { get; set; }


        [Required]
        public string? Password { get; set; }

        public Role Role { get; set; } 
    }
}
