using Microsoft.EntityFrameworkCore;

namespace DEMO.WebApi.Data;

public class DemoWebApiDbContext : DbContext
{
    public DemoWebApiDbContext(DbContextOptions<DemoWebApiDbContext> options): base(options)
    {
    }

    public DbSet<Models.Product> Products { get; set; }
}
