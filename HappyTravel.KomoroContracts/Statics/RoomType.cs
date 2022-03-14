using HappyTravel.KomoroContracts.Enums;

namespace HappyTravel.KomoroContracts.Statics;

public record RoomType
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public RoomCategories Category { get; init; }
}
