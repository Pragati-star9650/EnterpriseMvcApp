using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseMvcApp.Models
{
    public class UserCompanyAccess
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ServerId { get; set; }

        [Required]
        public int DatabaseId { get; set; }

        // Navigation Properties
        public UserMaster User { get; set; }
        public Server Server { get; set; }
        public Database Database { get; set; }
    }
}
