using System;

namespace LuiAFKUtl.LuiAFKCFG;

[Flags]
internal enum PotBuff : ulong
{
    None = 0uL,
    Campfire = 1uL,
    HeartLantern = 2uL,
    Honey = 4uL,
    StarBottle = 8uL,
    PeaceCandle = 0x10uL,
    WaterCandle = 0x20uL,
    AmmoRes = 0x40uL,
    Archery = 0x80uL,
    Battle = 0x100uL,
    Builder = 0x200uL,
    Calming = 0x400uL,
    Crates = 0x800uL,
    Dangersense = 0x1000uL,
    Endurance = 0x2000uL,
    Feather = 0x4000uL,
    Fishing = 0x8000uL,
    Flipper = 0x10000uL,
    Gills = 0x20000uL,
    Grav = 0x40000uL,
    Heartreach = 0x80000uL,
    Hunter = 0x100000uL,
    Ichor = 0x200000uL,
    Inferno = 0x400000uL,
    Invis = 0x800000uL,
    Ironskin = 0x1000000uL,
    Lifeforce = 0x2000000uL,
    MagicPower = 0x4000000uL,
    ManaRegen = 0x8000000uL,
    Mining = 0x10000000uL,
    NightOwl = 0x20000000uL,
    ObsidianSkin = 0x40000000uL,
    Rage = 0x80000000uL,
    Regen = 0x100000000uL,
    Shine = 0x200000000uL,
    Sonar = 0x400000000uL,
    Spelunker = 0x800000000uL,
    Summoning = 0x1000000000uL,
    Swiftness = 0x2000000000uL,
    Thorns = 0x4000000000uL,
    Tipsy = 0x8000000000uL,
    Titan = 0x10000000000uL,
    Warmth = 0x20000000000uL,
    WaterWalk = 0x40000000000uL,
    WellFed = 0x80000000000uL,
    Wrath = 0x100000000000uL,
    UltBattler = 0x200000000000uL,
    UltPeaceful = 0x400000000000uL,
    Wormhole = 0x800000000000uL,
    Recall = 0x1000000000000uL,
    AmmoBox = 0x2000000000000uL,
    Bewitching = 0x4000000000000uL,
    Crystal = 0x8000000000000uL,
    Sharpening = 0x10000000000000uL,
    Arena = 0xFuL,
    Basics = 0x82101000000uL,
    Battler = 0x120uL,
    Damage = 0x115080400000uL,
    Danger = 0x101000uL,
    Defense = 0x20002082000uL,
    BigFishing = 0x400008800uL,
    Flight = 0x44000uL,
    Gathering = 0xA70000000uL,
    Magic = 0xC000000uL,
    Melee = 0x8000200000uL,
    Peaceful = 0x410uL,
    Range = 0xC0uL,
    Station = 0x1E000000000000uL,
    Swimming = 0x40000030000uL,
    Travel = 0x1800000000000uL,
    Explorer = 0x40A70131200uL,
    Combat = 0x1E1BF18F6820CFuL,
    Everything = 0x1FFFFFFFFFFACFuL
}
