using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class ResourceDataContext : DbContext
{
    public ResourceDataContext(DbContextOptions<ResourceDataContext> options) : base(options) { }

    public DbSet<Resource> Resources { get; set; } 
}