using Microsoft.EntityFrameworkCore;
using NewsPortal.Areas.Admin.Models;
using NewsPortal.Models;
using System.Data;

namespace NewsPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "admin" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = "user" });
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Login="admin", Name="Super Admin",Email = "admin@admin.admin", Password = "admin@admin.admin", RoleId = 1 });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles {get; set; }
        public DbSet<New> News { get; set; }
    }
}
