using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Accessories;

public class UnlimitedManaAccessory1 : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Unlimited Mana 1");
        // Tooltip.SetDefault("Unlimited mana.\nMagic damage reduced by 20%.");
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory2>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory3>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory4>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory5>()))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.accessory = true;
        Item.value = 100000;
        Item.rare = ItemRarityID.Orange;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.manaCost *= 0f;
        player.GetDamage(DamageClass.Magic) -= 0.2f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
           .AddIngredient(ModContent.ItemType<UnlimitedManaAccessory>(), 1)
           .AddIngredient(ItemID.GlowingMushroom, 200)
           .AddIngredient(ItemID.Bone, 30)
           .AddTile(TileID.TinkerersWorkbench)
           .Register();
    }
}
