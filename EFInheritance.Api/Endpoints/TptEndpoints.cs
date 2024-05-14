namespace EFInheritance.Api.Endpoints;

public static class TptEndpoints
{
    public static void RegisterTptEndpoints(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("Tpt");

        group.MapGet("/animals", GetAnimalsAsync);
        group.MapGet("/cats", GetCatsAsync);
        group.MapGet("/dogs", GetDogsAsync);

        group.MapPost("/animals", CreateAnimalAsync);
        group.MapPost("/cats", CreateCatAsync);
        group.MapPost("/dogs", CreateDogAsync);
    }

    private static async Task<IEnumerable<Animal>> GetAnimalsAsync(TptContext context)
    {
        var animals = await context.Animals.OrderBy(a => a.Name).ToListAsync();
        return animals;
    }

    private static async Task<IEnumerable<Cat>> GetCatsAsync(TptContext context)
    {
        var cats = await context.Cats.OrderBy(a => a.Name).ToListAsync();
        return cats;
    }

    private static async Task<IEnumerable<Dog>> GetDogsAsync(TptContext context)
    {
        var dogs = await context.Dogs.OrderBy(a => a.Name).ToListAsync();
        return dogs;
    }

    private static async Task CreateAnimalAsync(TptContext context)
    {
        var animal = new Animal() { Name = "Animal 1" };
        await context.Animals.AddAsync(animal);
        await context.SaveChangesAsync();
    }

    private static async Task CreateCatAsync(TptContext context)
    {
        var cat = new Cat() { Name = "Cat 1", Sound = "Mao" };
        await context.Cats.AddAsync(cat);
        await context.SaveChangesAsync();
    }

    private static async Task CreateDogAsync(TptContext context)
    {
        var dog = new Dog() { Name = "Dog 1", Breed = "Leri" };
        await context.Dogs.AddAsync(dog);
        await context.SaveChangesAsync();
    }
}