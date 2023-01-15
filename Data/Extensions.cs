namespace dotnet_api.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (IServiceScope? scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services
                                            .GetRequiredService<RecipeContext>();
                context.Database.EnsureCreated();
                DbInit.Init(context);
            }
        }
    }
}