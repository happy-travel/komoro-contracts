namespace HappyTravel.KomoroContracts.Bookings;

public record Booking
{
    public string ReferenceCode { get; init; } = string.Empty;
    public List<RoomOccupation> Rooms { get; init; } = null!;
}
