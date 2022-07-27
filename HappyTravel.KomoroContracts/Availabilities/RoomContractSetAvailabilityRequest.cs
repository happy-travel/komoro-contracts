using HappyTravel.EdoContracts.Accommodations;

namespace HappyTravel.KomoroContracts.Availabilities;

public record RoomContractSetAvailabilityRequest
{
    public AvailabilityRequest AvailabilityRequest { get; init; }
    public List<RoomContractRequest> RoomContractRequests { get; init; } = new();
}
