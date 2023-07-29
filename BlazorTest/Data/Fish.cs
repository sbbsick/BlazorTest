using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Data;

public class Fish
{
    public Fish()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    public int Length { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    public float Weight { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    public EFishType Type { get; set; }

}