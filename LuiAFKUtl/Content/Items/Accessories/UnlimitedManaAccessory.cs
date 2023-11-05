using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Accessories;

public class UnlimitedManaAccessory : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Unlimited Mana");
        // Tooltip.SetDefault("Unlimited mana.\nMagic damage reduced by 30%.");
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.accessory = true;
        Item.value = 75000;
        Item.rare = ItemRarityID.Green;
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory1>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory2>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory3>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory4>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory5>()))
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
        player.GetDamage(DamageClass.Magic) -= 0.3f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
           .AddIngredient(ItemID.LesserManaPotion, 225)
           .AddIngredient(ItemID.ManaRegenerationBand, 1)
           .AddTile(TileID.TinkerersWorkbench)
           .Register();
    }
}
