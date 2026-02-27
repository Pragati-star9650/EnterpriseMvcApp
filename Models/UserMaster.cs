using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class UserMaster
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

      /*  [Required]
        public int ServerId { get; set; }

        [Required]
        public int DatabaseId { get; set; }
      */

        public bool IsActive { get; set; } = true;
    }
}
