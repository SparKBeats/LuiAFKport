using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Accessories;

public class ToolTime : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Tool Time!");
        // Tooltip.SetDefault("Tool, painting, tile, and wall speed increased.\nRange increased.");
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<FasterMining>() || player.armor[i].type == ModContent.ItemType<SuperToolTime>()))
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
        Item.width = 32;
        Item.height = 32;
        Item.value = 55000;
        Item.rare = ItemRarityID.Blue;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            Item val = player.inventory[player.selectedItem];
            if ((val.hammer > 0 || val.axe > 0 || val.pick > 0 || val.createTile >= ItemID.DirtBlock || val.createWall >= 0 || val.type == ItemID.Paintbrush || val.type == ItemID.PaintRoller || val.type == ItemID.PaintScraper || val.type == ItemID.SpectrePaintbrush || val.type == ItemID.SpectrePaintRoller || val.type == ItemID.SpectrePaintScraper) && !val.channel)
            {
                player.itemTime /= 2;
                player.tileSpeed /= 2;
            }
            Player.tileRangeX = 8;
            Player.tileRangeY = 8;
        }
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<FasterMining>(), 1)
            .AddIngredient(ItemID.Bone, 30)
            .AddIngredient(ItemID.HellstoneBar, 10)
            .AddIngredient(ItemID.BuilderPotion, 5)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
