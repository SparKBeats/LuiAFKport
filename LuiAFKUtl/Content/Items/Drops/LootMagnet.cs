using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Drops;

public class LootMagnet : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Loot Magnet");
        // Tooltip.SetDefault("Loots everything.");
    }

    public override void SetDefaults()
    {
        Item.width = 26;
        Item.height = 28;
        Item.rare = ItemRarityID.Red;
        Item.holdStyle = 2;
    }

    public override void HoldItem(Player player)
    {
        for (int i = 0; i < 400; i++)
        {
            Item val = Main.item[i];
            if (((Entity)val).active && val.noGrabDelay == 0 && ItemLoader.CanPickup(val, player))
            {
                val.beingGrabbed = true;
                Vector2 val2 = ((Entity)player).Center - ((Entity)val).Center;
                ((Entity)val).velocity = (((Entity)val).velocity * 4f + val2 * (20f / ((Vector2)(val2)).Length())) * 0.2f;
            }
        }
    }
}
