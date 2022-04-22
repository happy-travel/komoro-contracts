namespace HappyTravel.KomoroContracts.Availabilities;

public record class AvailabilityRestriction
{
    public string SupplierCode { get; init; } = string.Empty;
    public string PropertyCode { get; init; } = string.Empty;
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public string RoomTypeCode { get; init; } = string.Empty;
    public string RatePlanCode { get; init; } = string.Empty;
    public RestrictionStatusDetails? RestrictionStatusDetails { get; init; }
    public StayDurationDetails? StayDurationDetails { get; init; }
}
