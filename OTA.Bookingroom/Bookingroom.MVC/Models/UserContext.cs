using Microsoft.EntityFrameworkCore;

namespace Bookingroom.MVC.Models;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        string adminRoleName = "admin";
        string userRoleName = "user";

        string adminEmail = "admin@mail.ru";
        string adminPassword = "12345678admin";
        string adminName = "admin";

        // добавляем роли
        Role adminRole = new Role { Id = 1, Name = adminRoleName };
        Role userRole = new Role { Id = 2, Name = userRoleName };
        User adminUser = new User { Id = 1, Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id,Name= adminName};

        modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
        modelBuilder.Entity<User>().HasData(new User[] { adminUser });
        base.OnModelCreating(modelBuilder);
    }
}
