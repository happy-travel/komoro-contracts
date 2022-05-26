namespace HappyTravel.KomoroContracts.Availabilities;

public record UpdateInventoryRequest
{
    public string SupplierCode { get; init; } = string.Empty;
    public string PropertyCode { get; init; } = string.Empty;

    public List<InventoryDetails> InventoryDetails { get; init; } = null!;
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public string RoomTypeCode { get; init; } = null!;
    public string RatePlanCode { get; init; } = string.Empty;
    public int NumberOfAvailableRooms { get; init; }
}
