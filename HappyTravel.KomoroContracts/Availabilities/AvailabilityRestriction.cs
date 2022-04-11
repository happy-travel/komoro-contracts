namespace HappyTravel.KomoroContracts.Availabilities;

public record class AvailabilityRestriction
{
    public int Id { get; init; }
    public string PropertyCode { get; init; } = string.Empty;
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public string RoomTypeCode { get; init; } = string.Empty;
    public string RatePlanCode { get; init; } = string.Empty;
    public RestrictionStatus? RestrictionStatus { get; init; }
    public LengthOfStay? LengthOfStay { get; init; }
}
