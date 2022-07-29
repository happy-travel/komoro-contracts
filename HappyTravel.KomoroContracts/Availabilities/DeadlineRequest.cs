namespace HappyTravel.KomoroContracts.Availabilities;

public record DeadlineRequest
{
    public DateTimeOffset CheckInDate { get; init; }
    public DateTimeOffset CheckOutDate { get; init; }
}
