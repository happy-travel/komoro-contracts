using HappyTravel.EdoContracts.General.Enums;

namespace HappyTravel.KomoroContracts.Bookings;

public record Passenger
{
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public PassengerTitles Title { get; init; }
    public int? Age { get; init; }
    public bool IsLeader { get; init; }
}
