using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace LuiAFKUtl.Content.Items.Accessories;

public class SuperToolTime : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Home Improvement");
        // Tooltip.SetDefault("Everything is faster.");
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<FasterMining>() || player.armor[i].type == ModContent.ItemType<ToolTime>()))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public override void SetDefaults()
    {
        Item.accessory = true;
        Item.width = 56;
        Item.height = 54;
        Item.value = 55500;
        Item.rare = ItemRarityID.Quest;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            Item val = player.inventory[player.selectedItem];
            if ((val.hammer > 0 || val.axe > 0 || val.pick > 0 || val.createTile >= TileID.Dirt || val.createWall >= 0 || val.type == ItemID.Paintbrush || val.type == ItemID.PaintRoller || val.type == ItemID.PaintScraper || val.type == ItemID.SpectrePaintbrush || val.type == ItemID.SpectrePaintRoller || val.type == ItemID.SpectrePaintScraper) && !val.channel)
            {
                player.itemTime = 1;
                player.tileSpeed = 1;
            }
            Player.tileRangeX = 50;
            Player.tileRangeY = 50;
        }
        player.autoPaint = true;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<ToolTime>(), 1)
            .AddIngredient(ItemID.ArchitectGizmoPack, 1)
            .AddIngredient(ItemID.LunarBar, 20)
            .AddIngredient(ItemID.FragmentVortex, 40)
            .AddIngredient(ItemID.FragmentSolar, 40)
            .AddIngredient(ItemID.FragmentStardust, 40)
            .AddIngredient(ItemID.FragmentNebula, 40)
            .AddIngredient(ItemID.BuilderPotion, 30)
            .AddTile(TileID.LunarCraftingStation)
            .Register();
    }
}
