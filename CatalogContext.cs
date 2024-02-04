namespace CatalogApp;

using CatalogApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class CatalogContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public IConfiguration _configuration;

    public CatalogContext(DbContextOptions<CatalogContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    public CatalogContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("CatalogConnection"));
    }
}