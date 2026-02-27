using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class SignupViewModel
    {
        [Required]
        public int ServerId { get; set; }

        [Required]
        public int DatabaseId { get; set; }

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        // Optional fields when creating new server/database during signup
        public string? NewServerName { get; set; }
        public string? NewDatabaseName { get; set; }
    }
}

