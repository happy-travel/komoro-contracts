namespace HappyTravel.KomoroContracts.Bookings;

public record RoomOccupation
{
    public string RoomTypeCode { get; init; } = string.Empty;
    public string RatePlanCode { get; init; } = string.Empty;
    public bool IsExtraBedNeeded { get; init; }
    public List<Passenger> Passengers { get; init; } = null!;
}
