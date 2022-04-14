namespace HappyTravel.KomoroContracts.Availabilities;

public record StayDurationDetails
{
    public bool IsArrivalDateBased { get; init; }
    public int MinimumDays { get; init; }
}
