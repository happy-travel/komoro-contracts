namespace HappyTravel.KomoroContracts.Statics;

public record MealPlan
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}
