namespace HappyTravel.KomoroContracts.Availabilities;

public record RoomContractRequest
{
    public string RoomTypeCode { get; init; } = string.Empty;
    public string RatePlanCode { get; init; } = string.Empty;
}
