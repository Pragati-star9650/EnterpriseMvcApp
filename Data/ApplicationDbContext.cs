using EnterpriseMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        // ✅ Server master
        public DbSet<ServerMaster> ServerMasters { get; set; }
    }
}
