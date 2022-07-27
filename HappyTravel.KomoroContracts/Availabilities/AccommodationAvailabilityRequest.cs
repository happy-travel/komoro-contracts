namespace HappyTravel.KomoroContracts.Availabilities;

public record AccommodationAvailabilityRequest
{
    public string AccommodationId { get; init; } = string.Empty;
    public List<RoomContractSetRequest> RoomContractSetRequests = new();
}
