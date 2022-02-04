namespace HappyTravel.KomoroContracts.Statics;

public class Address
{
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public Country Country { get; set; } = null!;
}
