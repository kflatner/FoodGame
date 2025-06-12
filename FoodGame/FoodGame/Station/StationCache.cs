namespace FoodGame.Station;

public static class StationCache
{
    public static Station[] AllStations { get; } =
    [
        new Station { Id = 1, Name = "Kitchen", Type = StationType.Kitchen },
        new Station { Id = 2, Name = "Brewery", Type = StationType.Brewery }
    ];
}