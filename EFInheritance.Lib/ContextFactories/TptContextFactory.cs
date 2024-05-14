using EFInheritance.Lib.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFInheritance.Lib.ContextFactories;

public class TptContextFactory : IDesignTimeDbContextFactory<TptContext>
{
    public TptContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TptContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tpt;Integrated Security=True");
        return new TptContext(optionsBuilder.Options);
    }
}
