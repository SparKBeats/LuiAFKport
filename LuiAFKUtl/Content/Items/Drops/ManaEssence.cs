using Terraria;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Drops;

public class ManaEssence : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Mana Essence");
        // Tooltip.SetDefault("Imbued with magical power.\nSmells a little like fish.");
    }

    public override void SetDefaults()
    {
        Item.width = 14;
        Item.height = 22;
        Item.maxStack = 9999;
    }
}
