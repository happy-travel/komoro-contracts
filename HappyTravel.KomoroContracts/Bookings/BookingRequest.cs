namespace HappyTravel.KomoroContracts.Bookings;

public record BookingRequest
{
    public string ReferenceCode { get; init; } = string.Empty;
    public DateOnly CheckInDate { get; init; }
    public DateOnly CheckOutDate { get; init; }
    public List<RoomOccupation> Rooms { get; init; } = null!;
}
