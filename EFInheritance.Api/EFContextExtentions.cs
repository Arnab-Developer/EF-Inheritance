namespace EFInheritance.Api;

internal static class EFContextExtentions
{
    public static void AddEFContexts(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var defaultConstr = configuration.GetConnectionString("Default");
        var tptConstr = configuration.GetConnectionString("Tpt");
        var tpcConstr = configuration.GetConnectionString("Tpc");

        serviceCollection.AddSqlServer<DefaultContext>(defaultConstr, x => x.MigrationsAssembly("EFInheritance.Lib"));
        serviceCollection.AddSqlServer<TptContext>(tptConstr, x => x.MigrationsAssembly("EFInheritance.Lib"));
        serviceCollection.AddSqlServer<TpcContext>(tpcConstr, x => x.MigrationsAssembly("EFInheritance.Lib"));
    }
}