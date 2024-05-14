using EFInheritance.Lib.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFInheritance.Lib.ContextFactories;

public class DefaultContextFactory : IDesignTimeDbContextFactory<DefaultContext>
{
    public DefaultContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DefaultContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Default;Integrated Security=True");
        return new DefaultContext(optionsBuilder.Options);
    }
}