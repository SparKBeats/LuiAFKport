using LuiAFKUtl.Content.Items.Drops;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.Content.Items.Accessories;

public class UnlimitedManaAccessory5 : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Unlimited Mana 5");
        // Tooltip.SetDefault("Unlimited mana.\nMagic damage increased by 10%.\nMagic crit increased by 10%.");
    }

    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 24;
        Item.accessory = true;
        Item.value = 100000;
        Item.rare = ItemRarityID.Red;
    }
    public override bool CanEquipAccessory(Player player, int slot, bool modded)
    {
        if (slot < 10)
        {
            for (int i = 3; i < 10; i++)
            {
                if (i != slot && (player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory1>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory2>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory3>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory4>() || player.armor[i].type == ModContent.ItemType<UnlimitedManaAccessory>()))
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
        player.GetDamage(DamageClass.Magic) += 0.1f;
        player.GetCritChance(DamageClass.Magic) += 0.1f;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
         .AddIngredient(ModContent.ItemType<UnlimitedManaAccessory4>(), 1)
         .AddIngredient(ItemID.FragmentNebula, 15)
         .AddIngredient(ModContent.ItemType<MagicEssence>(), 1)
         .AddIngredient(ModContent.ItemType<ManaEssence>(), 1)
         .AddTile(TileID.LunarCraftingStation)
         .Register();
    }
}
