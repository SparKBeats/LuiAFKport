using LuiAFKUtl.LuiAFKCFG;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.TogglePots;

public class UltimatePeaceful : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Ultimate Peaceful");
        // Tooltip.SetDefault("It's oh so quiet.\nGreatly reduced spawns.\nFavorite this item to toggle the effect.");
    }

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Pink;
    }
    public override void UpdateInventory(Player player)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            if (Item.favorited == true && !player.GetModPlayer<LuiafkPlayer>().UltBattler)
            {
                player.GetModPlayer<LuiafkPlayer>().UltPeaceful = true;
                player.GetModPlayer<LuiafkPlayer>().MaxSpawnsMultiplier = 0.01f;
                player.GetModPlayer<LuiafkPlayer>().SpawnRateMultiplier = 0.01f;
                player.enemySpawns = false;
            }
            else
            {
                player.GetModPlayer<LuiafkPlayer>().MaxSpawnsMultiplier = 1f;
                player.GetModPlayer<LuiafkPlayer>().SpawnRateMultiplier = 1f;
            }
        }
    }
    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemID.Sunflower, 100)
            .AddIngredient(ItemID.SoulofLight, 30)
            .AddIngredient(ItemID.CalmingPotion, 30)
            .AddIngredient(ItemID.PixieDust, 30)
            .AddIngredient(ItemID.UnicornHorn, 3)
            .AddTile(TileID.Bottles)
            .Register();
    }
}