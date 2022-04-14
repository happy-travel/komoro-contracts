using HappyTravel.KomoroContracts.Enums;

namespace HappyTravel.KomoroContracts.Availabilities
{
    public record RestrictionStatusDetails
    {
        public RestrictionTypes? Restriction { get; init; }
        public RestrictionStatuses? Status { get; init; }
        public int? MinAdvancedBookingOffset { get; init; }
    }
}
