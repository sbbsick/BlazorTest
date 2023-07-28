namespace BlazorTest.Data;

public class Fish
{
    public Fish()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Length { get; set; }
    public float Weight { get; set; }
    public EFishType Type { get; set; }

}