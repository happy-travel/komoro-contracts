namespace HappyTravel.KomoroContracts.Availabilities;

public class Inventory
{
    public string SupplierCode { get; init; } = string.Empty;
    public string PropertyCode { get; init; } = string.Empty;
    public List<InventoryDetails> InventoryDetails { get; init; } = new(0);
}
