﻿using HappyTravel.Geography;

namespace HappyTravel.KomoroContracts.Statics;

public record Property
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string SupplierCode { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public Address Address { get; init; } = null!;
    public GeoPoint Coordinates { get; init; } = new();
    public string Phone { get; init; } = string.Empty;
    public int StarRating { get; init; }
    public Contact PrimaryContact { get; init; } = null!;
    public string ReservationEmail { get; init; } = string.Empty;
    public TimeSpan CheckInTime { get; init; }
    public TimeSpan CheckOutTime { get; init; }
    public PassengerAge PassengerAge { get; init; } = null!;
    public List<Room>? Rooms { get; init; }
    public List<CancellationPolicy>? CancellationPolicies { get; init; }
}
