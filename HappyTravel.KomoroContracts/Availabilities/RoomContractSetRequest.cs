namespace HappyTravel.KomoroContracts.Availabilities
{
    public record RoomContractSetRequest
    {
        public Guid RoomContractSetId { get; init; }
        public List<RoomContractRequest> RoomContractRequests { get; init; } = new();
    }
}
