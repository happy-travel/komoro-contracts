namespace HappyTravel.KomoroContracts.Availabilities;

public record AvailabilityRestrictionRequest
{
    public string SupplierCode { get; init; } = string.Empty;
    public string PropertyCode { get; init; } = string.Empty;
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public List<string> RatePlanCodes { get; init; } = null!;
    public List<string> RoomTypeCodes { get; init; } = null!;
}
