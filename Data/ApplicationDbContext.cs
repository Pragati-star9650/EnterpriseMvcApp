using EnterpriseMvcApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace EnterpriseMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCompanyAccess>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserCompanyAccess>()
                .HasOne(u => u.Server)
                .WithMany()
                .HasForeignKey(u => u.ServerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserCompanyAccess>()
                .HasOne(u => u.Database)
                .WithMany()
                .HasForeignKey(u => u.DatabaseId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        // ✅ Server master
        public DbSet<Server> Servers { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<UserCompanyAccess> UserCompanyAccess { get; set; }

    }
}
