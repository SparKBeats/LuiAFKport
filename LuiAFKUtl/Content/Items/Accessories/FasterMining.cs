using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace LuiAFKUtl.Content.Items.Accessories;

public class FasterMining : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Dig Faster");
        // Tooltip.SetDefault("Mining speed increased by 33%.");
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<ToolTime>() || player.armor[i].type == ModContent.ItemType<SuperToolTime>()))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public override void SetDefaults()
    {
        Item.hasVanityEffects = true;
        Item.accessory = true;
        Item.width = 34;
        Item.height = 32;
        Item.value = 50000;
        Item.rare = ItemRarityID.Green;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.pickSpeed -= 0.33f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddRecipeGroup(RecipeGroupID.Wood, 100)
            .AddIngredient(ItemID.StoneBlock, 100)
            .AddIngredient(ItemID.IronBar, 5)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
