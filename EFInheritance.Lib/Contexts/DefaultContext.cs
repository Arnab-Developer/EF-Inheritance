using EFInheritance.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFInheritance.Lib.Contexts;

public class DefaultContext(DbContextOptions<DefaultContext> options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Dog> Dogs { get; set; }
}

// Run this to create migration
// Add-Migration -Name "InitialCreate" -Context "EFInheritance.Lib.Contexts.DefaultContext" -OutputDir "Migrations\Default"
// Update-Database -Context "EFInheritance.Lib.Contexts.DefaultContext"