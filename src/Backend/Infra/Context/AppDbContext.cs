using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infra.Context;
public class AppDbContext : DbContext
{
    public AppDbContext()
    { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=YourDatabaseName.db;");
    }

    public virtual DbSet<Student> Students { get; set; }
    //public virtual DbSet<Teacher> Teacher { get; set; }
    //public virtual DbSet<Class> Classes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}