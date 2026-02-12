using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Server Name")]
        public string ServerName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Database Name")]
        public string DatabaseName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;
    }
}
