using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace LuiAFKUtl.Content.Items.Accessories;

public class UnlimitedManaAccessory4 : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Unlimited Mana 4");
        // Tooltip.SetDefault("Unlimited mana.");
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 44;
        Item.accessory = true;
        Item.value = 100000;
        Item.rare = ItemRarityID.Yellow;
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory1>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory2>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory3>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory5>()))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.manaCost *= 0f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
         .AddIngredient(ModContent.ItemType<UnlimitedManaAccessory3>(), 1)
         .AddIngredient(ItemID.BeetleHusk, 15)
         .AddTile(TileID.TinkerersWorkbench)
         .Register();
    }
}
