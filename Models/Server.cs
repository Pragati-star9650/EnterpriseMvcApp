using System.Collections.Generic;
namespace EnterpriseMvcApp.Models
{
    public class Server
    {
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public bool ServerStatus { get; set; }

        public virtual ICollection<Database> Databases { get; set; }

    }
}