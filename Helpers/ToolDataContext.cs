using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class ToolDataContext : DbContext
{
    // When used with ASP.net core, add these lines to Startup.cs
    //   var connectionString = Configuration.GetConnectionString("BlogContext");
    //   services.AddEntityFrameworkNpgsql().AddDbContext<BlogContext>(options => options.UseNpgsql(connectionString));
    // and add this to appSettings.json
    // "ConnectionStrings": { "BlogContext": "Server=localhost;Database=blog" }

    public ToolDataContext(DbContextOptions<ToolDataContext> options) : base(options) { }

    public DbSet<ToolEntity> Tools { get; set; }

    public DbSet<ResourceEntity> Resources { get; set; }
}
