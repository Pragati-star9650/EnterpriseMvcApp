using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class LoginViewModel
    {
        [Required]
        public int ServerId { get; set; }

        [Required]
        public int DatabaseId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
