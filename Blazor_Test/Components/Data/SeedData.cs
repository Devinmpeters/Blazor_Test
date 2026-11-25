using Microsoft.EntityFrameworkCore;
using Blazor_Test.Components.Models;
using Blazor_Test.Components.Data;

namespace Blazor_Test.Components.Data;

public class SeedData
{
   public static void Initialize(IServiceProvider ServiceProvider)
    {
        using var context = new Blazor_TestContext(ServiceProvider.GetRequiredService<DbContextOptions<Blazor_TestContext>>());

        if (context == null || context.PlayerNames == null)
        {
            throw new NullReferenceException(
                "Null Blazor_TestContext or PlayerNames DbSet");
        }

        if (context.PlayerNames.Any())
        {
            return;
        }

        
    }
}