using System.ComponentModel.DataAnnotations;

namespace EnterpriseMvcApp.Models
{
    public class ServerMaster
    {
        [Key]
        public int ServerId { get; set; }
        public string ServerName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}

