using BlazorTest.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Context;

public class MyDbContext : DbContext
{
    public DbSet<Fish> Fishes { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fish>().HasKey(x => x.Id);
        modelBuilder.Entity<Fish>().Property(x => x.Name).IsRequired();
        modelBuilder.Entity<Fish>().Property(x => x.Length).IsRequired();
        modelBuilder.Entity<Fish>().Property(x => x.Weight).IsRequired();
        modelBuilder.Entity<Fish>().Property(x => x.Type).IsRequired();
    }

    public async Task SeedData()
    {
        var listFishes = new List<Fish>
        {
            new Fish { Name = "Trout", Length = 10, Weight = 2.8f, Type = EFishType.Freshwater },
            new Fish { Name = "Salmon", Length = 30, Weight = 10.8f, Type = EFishType.Saltwater },
            new Fish { Name = "Piranha", Length = 14, Weight = 6.8f, Type = EFishType.Freshwater },
            new Fish { Name = "Pacu", Length = 20, Weight = 12.8f, Type = EFishType.Freshwater },
            new Fish { Name = "Salmon2", Length = 10, Weight = 2.8f, Type = EFishType.Saltwater },
        };

        foreach (var fish in listFishes)
        {
            if (!await Fishes.AnyAsync(x => x.Name == fish.Name))
            {
                await Fishes.AddAsync(fish);
            }
        }
        await SaveChangesAsync();
    }

    public void DeleteFish(Guid id)
    {
        var fish = Fishes.FirstOrDefault(x => x.Id == id);
        if (fish != null)
        {
            Fishes.Remove(fish);
        }
    }

}