using HappyTravel.KomoroContracts.Enums;

namespace HappyTravel.KomoroContracts;

public record ErrorDetails
{
    public ErrorCodes ErrorCode { get; init; }
    public string? EntityCode { get; init; }
}
