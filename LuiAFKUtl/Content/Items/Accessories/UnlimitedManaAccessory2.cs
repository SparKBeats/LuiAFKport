using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Accessories;

public class UnlimitedManaAccessory2 : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Unlimited Mana 2");
        // Tooltip.SetDefault("Unlimited mana.\nMagic damage reduced by 10%.");
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 28;
        Item.accessory = true;
        Item.value = 100000;
        Item.rare = ItemRarityID.LightRed;
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory1>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory3>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory4>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory5>()))
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
        player.GetDamage(DamageClass.Magic) -= 0.1f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
           .AddIngredient(ModContent.ItemType<UnlimitedManaAccessory1>(), 1)
           .AddIngredient(ItemID.SorcererEmblem, 1)
           .AddIngredient(ItemID.GreaterManaPotion, 225)
           .AddTile(TileID.TinkerersWorkbench)
           .Register();
    }
}
