using EFInheritance.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFInheritance.Lib.Contexts;

public class DefaultContext(DbContextOptions<DefaultContext> options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public DbSet<Dog> Dogs { get; set; }
}