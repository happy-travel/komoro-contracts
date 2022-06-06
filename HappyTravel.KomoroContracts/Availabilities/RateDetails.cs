using HappyTravel.Money.Enums;

namespace HappyTravel.KomoroContracts.Availabilities;

public record RateDetails
{
    public string RoomTypeCode { get; init; } = string.Empty;
    public Currencies CurrencyCode { get; init; }
    public List<BaseRate>? BaseRates { get; init; }
    public List<AdditionalRate>? AdditionalRates { get; init; }
}
