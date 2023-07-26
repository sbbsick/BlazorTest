using BlazorTest.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Context;

public class MyDbContext : DbContext
{
    public DbSet<Fish> Fishes { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }

    public void AddRange(IEnumerable<Fish> fishes)
    {
        foreach (var fish in fishes)
        {
            Fishes.Add(fish);
        }
    }
}