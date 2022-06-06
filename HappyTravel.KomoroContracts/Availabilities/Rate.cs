namespace HappyTravel.KomoroContracts.Availabilities;

public record Rate
{
    public string SupplierCode { get; init; } = string.Empty;
    public string PropertyCode { get; init; } = string.Empty;
    public List<RatePlan> RatePlans { get; init; } = new(0);
}
