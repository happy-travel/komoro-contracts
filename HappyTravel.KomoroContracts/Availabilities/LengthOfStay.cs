namespace HappyTravel.KomoroContracts.Availabilities;

public record LengthOfStay
{
    public bool IsArrivalDateBased { get; init; }
    public int MinimumDays { get; init; }
}
