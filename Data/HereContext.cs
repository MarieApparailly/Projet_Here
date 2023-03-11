using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projet_Here.Models;

namespace Projet_Here.Data;


public class HereContext : DbContext
{
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Mission> Missions { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Place> Places { get; set; } = null!;
    public DbSet<Enrollment> Enrollments { get; set; } = null!;


    public string DbPath { get; private set; }


    public HereContext()
    {
        // Path to SQLite database file
        DbPath = "Here.db";
    }


    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}
