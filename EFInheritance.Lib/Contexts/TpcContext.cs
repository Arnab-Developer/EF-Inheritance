namespace EFInheritance.Lib.Contexts;

public class TpcContext(DbContextOptions<TpcContext> options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>().UseTpcMappingStrategy().ToTable("Animals");
        builder.Entity<Cat>().ToTable("Cats");
        builder.Entity<Dog>().ToTable("Dogs");
    }
}

// Run this to create migration
// Add-Migration -Name "InitialCreate" -Context "EFInheritance.Lib.Contexts.TpcContext" -OutputDir "Migrations\Tpc"
// Update-Database -Context "EFInheritance.Lib.Contexts.TpcContext"