using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Blazor_Test.Components.Models;

namespace Blazor_Test.Components.Models;

internal class Blazor_TestContext : DbContext
{
    public Blazor_TestContext(DbContextOptions<Blazor_TestContext> options) : base(options) { }
    public DbSet<PlayerNames> PlayerNames { get; set; }
    public DbSet<DieTypes> DieTypes { get; set; }
    public DbSet<PlayerInfo> PlayerInfo { get; set; }
}