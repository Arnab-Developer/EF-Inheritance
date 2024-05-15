namespace EFInheritance.Api;

internal static class EFContextExtentions
{
    public static void AddEFContexts(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var defaultConstr = configuration.GetConnectionString("Default");
        var tptConstr = configuration.GetConnectionString("Tpt");
        var tpcConstr = configuration.GetConnectionString("Tpc");

        serviceCollection.AddSqlServer<DefaultContext>(defaultConstr);
        serviceCollection.AddSqlServer<TptContext>(tptConstr);
        serviceCollection.AddSqlServer<TpcContext>(tpcConstr);
    }
}