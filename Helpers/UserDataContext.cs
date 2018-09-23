using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class UserDataContext : DbContext
{
    // When used with ASP.net core, add these lines to Startup.cs
    //   var connectionString = Configuration.GetConnectionString("BlogContext");
    //   services.AddEntityFrameworkNpgsql().AddDbContext<BlogContext>(options => options.UseNpgsql(connectionString));
    // and add this to appSettings.json
    // "ConnectionStrings": { "BlogContext": "Server=localhost;Database=blog" }

    public UserDataContext(DbContextOptions<UserDataContext> options) : base(options) { }

    public DbSet<UserEntity> Users { get; set; } 

    public DbSet<RoleEntity> Roles { get; set; }

}
