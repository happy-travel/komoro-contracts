namespace HappyTravel.KomoroContracts.Availabilities;

public record InventoryDetails
{
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public string RoomTypeCode { get; init; } = string.Empty;
    public string RatePlanCode { get; init; } = string.Empty;
    public int NumberOfAvailableRooms { get; init; }
    public int? NumberOfBookedRooms { get; init; }
}
