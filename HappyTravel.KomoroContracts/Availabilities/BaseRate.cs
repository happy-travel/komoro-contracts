namespace HappyTravel.KomoroContracts.Availabilities;

public record BaseRate
{
    public decimal AmountBeforeTax { get; init; }
    public decimal AmountAfterTax { get; init; }
    public int? NumberOfGuests { get; init; }
    public int? AgeQualifyingCode { get; init; }
}
