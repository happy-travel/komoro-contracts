namespace HappyTravel.KomoroContracts.Availabilities;

public record AdditionalRate
{
    public decimal Amount { get; init; }
    public int? AgeQualifyingCode { get; init; }
}
