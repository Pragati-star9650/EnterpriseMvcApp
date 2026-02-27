namespace EnterpriseMvcApp.Models
{
    public class Database
    {
        public int DatabaseId { get; set; }
        public int ServerId { get; set; }
        public string DatabaseName { get; set; }
        public string DbUser { get; set; }
        public string DbPassword { get; set; }
        public bool IsActive { get; set; }

       public virtual Server Server { get; set; }
    }
}
