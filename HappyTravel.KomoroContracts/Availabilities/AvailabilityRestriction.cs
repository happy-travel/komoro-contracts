namespace HappyTravel.KomoroContracts.Availabilities;

public record class AvailabilityRestriction
{
    public int Id { get; init; }
    public int PropertyId { get; init; }
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public int RoomTypeId { get; init; }
    public string RatePlanCode { get; init; } = string.Empty;
    public RestrictionStatus? RestrictionStatus { get; init; }
    public LengthOfStay? LengthOfStay { get; init; }
}
