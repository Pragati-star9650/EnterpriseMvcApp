using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Server Name")]
        public string ServerName { get; set; } = string.Empty;

        [Display(Name = "Database Name")]
        public string DatabaseName { get; set; } = string.Empty;

        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;

        [Display(Name = "Password")]
        public string PasswordHash { get; set; } = string.Empty;
    }
}
