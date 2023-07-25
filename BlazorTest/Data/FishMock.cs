namespace BlazorTest.Data;

public class FishMock
{

    public Task<Fish[]> GetFishAsync()
    {
        var fish1 = new Fish();
        fish1.Name = "Bass";
        fish1.Length = 12;
        fish1.Weight = 2.5f;
        fish1.Type = EFishType.Freshwater;

        var fish2 = new Fish();
        fish2.Name = "Salmon";
        fish2.Length = 24;
        fish2.Weight = 5.5f;
        fish2.Type = EFishType.Saltwater;

        var fish3 = new Fish();
        fish3.Name = "Trout";
        fish3.Length = 18;
        fish3.Weight = 3.5f;
        fish3.Type = EFishType.Freshwater;

        var fish4 = new Fish();
        fish4.Name = "Tuna";
        fish4.Length = 36;
        fish4.Weight = 10.5f;
        fish4.Type = EFishType.Saltwater;

        var fish5 = new Fish();
        fish5.Name = "Catfish";
        fish5.Length = 24;
        fish5.Weight = 5.5f;
        fish5.Type = EFishType.Freshwater;
        return Task.FromResult(new Fish[] { fish1, fish2, fish3, fish4, fish5 });
    }
}