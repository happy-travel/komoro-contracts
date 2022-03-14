using System.ComponentModel;

namespace HappyTravel.KomoroContracts.Enums;

[Flags]
public enum RatePlans
{
    None = 0,

    [Description("Standard Room Only")]
    StandardRO = 1,

    [Description("Standard Bed & Breakfast")]
    StandardBB = 2,

    [Description("Stay Save Room Only")]
    StaySaveRO = 4,

    [Description("Stay Save Bed & Breakfast")]
    StaySaveBB = 8,

    [Description("Early Bird Room Only")]
    EarlyBirdRO = 16,

    [Description("Early Bird Bed & Breakfast")]
    EarlyBirdBB = 32,

    [Description("Special Deal Room Only")]
    SpecialDealRO = 64,

    [Description("Special Deal Bed & Breakfast")]
    SpecialDealBB = 128
}
