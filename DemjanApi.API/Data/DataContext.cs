using DemjanApi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DemjanApi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<UserPermission>()
            //     .HasKey(t => new { t.UserId, t.PermissionId });

            modelBuilder.Entity<UserPermission>()
            .HasKey(t => new { t.UserId, t.PermissionId });

            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPermissions)
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.Permission)
                .WithMany(p => p.UserPermissions)
                .HasForeignKey(p => p.PermissionId);
        }
    }
}