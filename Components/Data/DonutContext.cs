using DonutCo.Components.Data;
using Microsoft.EntityFrameworkCore;

public class DonutContext : DbContext
{
    public DonutContext(DbContextOptions<DonutContext> options) : base(options)
    {
    }

    // Define DbSets for your entities
    public DbSet<DonutItem> DonutItems { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional model configuration goes here if needed
    }
}