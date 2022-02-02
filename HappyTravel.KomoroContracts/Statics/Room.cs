using HappyTravel.KomoroContracts.Enums;
using HappyTravel.Money.Models;

namespace HappyTravel.KomoroContracts.Statics;

public record Room
{
    public int Id { get; init; }
    public int PropertyId { get; init; }
    public RoomType RoomType { get; init; } = null!;
    public MealPlan StandardMealPlan { get; init; } = null!;
    public Occupancy StandardOccupancy { get; init; } = null!;
    public List<Occupancy> MaximumOccupancy { get; init; } = null!;
    public MoneyAmount? ExtraAdultSupplement { get; init; }
    public MoneyAmount? ChildSupplement { get; init; }
    public MoneyAmount? InfantSupplement { get; init; }
    public RatePlans RatePlans { get; init; }
}
