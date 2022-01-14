using System.ComponentModel.DataAnnotations;

namespace TProject.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Account { get; set; }

        [Required]
        public string Password { get; set; }
    }
}