using Microsoft.EntityFrameworkCore;

namespace Models;

public class AppDbContext : DbContext
{
    public DbSet<Productos> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("TestDatabase");
    }
}
