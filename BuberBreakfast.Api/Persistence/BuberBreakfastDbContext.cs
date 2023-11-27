using BuberBreakfast.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BuberBreakfast.Api.Persistence;

public class BuberBreakfastDbContext : DbContext
{
    public BuberBreakfastDbContext(DbContextOptions<BuberBreakfastDbContext> options) : base(options)
    {
    }

    public DbSet<Breakfast> Breakfasts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BuberBreakfastDbContext).Assembly);
    }
}