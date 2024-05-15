namespace EFInheritance.Lib.ContextFactories;

public class TpcContextFactory : IDesignTimeDbContextFactory<TpcContext>
{
    public TpcContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TpcContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tpc;Integrated Security=True");
        return new TpcContext(optionsBuilder.Options);
    }
}
