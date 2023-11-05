using Terraria.ModLoader.Config;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LuiAFKUtl.LuiAFKCFG
{
    internal class LuiafkServerConfig : ModConfig
    {
        public override ConfigScope Mode => 0;

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            return true;
        }
    }
}
