namespace HappyTravel.KomoroContracts.Availabilities;

public record RatePlan
{
    public string RatePlanCode { get; init; } = string.Empty;
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public List<RateDetails> RateDetails { get; init; } = null!;
}
