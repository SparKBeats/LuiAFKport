using System;

namespace LuiAFKUtl.LuiAFKCFG;

[Flags]
internal enum PotToggles : ushort
{
    UltBattler = 1,
    UltPeaceful = 2,
    Grav = 4,
    Feather = 8,
    Inferno = 0x10,
    Invis = 0x20,
    Crate = 0x40,
    Spelunker = 0x80,
    DangerHunter = 0x100
}
