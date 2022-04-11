using HappyTravel.KomoroContracts.Enums;

namespace HappyTravel.KomoroContracts.Availabilities
{
    public record RestrictionStatus
    {
        public RestrictionTypes? Restriction { get; init; }
        public RestrictionStatuses? Status { get; init; }
        public int? MinAdvancedBookingOffset { get; init; }
    }
}
