using EFInheritance.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFInheritance.Lib.Contexts;

public class TpcContext(DbContextOptions<TpcContext> options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Dog> Dogs { get; set; }
}