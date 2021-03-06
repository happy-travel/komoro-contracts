using HappyTravel.EdoContracts.Accommodations;

namespace HappyTravel.KomoroContracts.Availabilities;

public record AccommodationAvailabilityRequest
{
    public AvailabilityRequest AvailabilityRequest { get; init; }
    public List<RoomContractSetRequest> RoomContractSetRequests { get; init; } = new();
}
