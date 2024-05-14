using EFInheritance.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFInheritance.Lib.Contexts;

public class TptContext(DbContextOptions<TptContext> options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>().UseTptMappingStrategy();
    }
}

// Run this to create migration
// Add-Migration -Name "InitialCreate" -Context "EFInheritance.Lib.Contexts.TptContext" -OutputDir "Migrations\Tpt"
// Update-Database -Context "EFInheritance.Lib.Contexts.TptContext"