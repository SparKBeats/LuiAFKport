using LuiAFKUtl.LuiAFKCFG;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.TogglePots;

public class UltimateBattler : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Ultimate Battler");
        // Tooltip.SetDefault("Are you sure you can handle this?\nMassively increased spawns.\nFavorite this item to toggle the effect.");
    }

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Red;
    }
    public override void UpdateInventory(Player player)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            if (Item.favorited == true)
            {
                player.GetModPlayer<LuiafkPlayer>().UltBattler = true;
                player.GetModPlayer<LuiafkPlayer>().MaxSpawnsMultiplier = 500f;
                player.GetModPlayer<LuiafkPlayer>().SpawnRateMultiplier = 100f;
                player.enemySpawns = true;
            }
            else
            {
                player.GetModPlayer<LuiafkPlayer>().MaxSpawnsMultiplier = 500f;
                player.GetModPlayer<LuiafkPlayer>().SpawnRateMultiplier = 100f;
            }
        }
    }
    public override void AddRecipes()
    {
        CreateRecipe()
            .AddRecipeGroup("EvilBars", 50)
            .AddIngredient(ItemID.SoulofNight, 30)
            .AddRecipeGroup("EvilPowders", 60)
            .AddIngredient(ItemID.BattlePotion, 30)
            .AddTile(TileID.Bottles)
            .Register();
    }
}
