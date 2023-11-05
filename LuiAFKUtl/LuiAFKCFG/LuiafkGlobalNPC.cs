using LuiAFKUtl.Content.Items.Drops;
using LuiAFKUtl.Content.Items.Misc;
using LuiAFKUtl.Content.Items.TogglePots;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuiAFKUtl.LuiAFKCFG;

public class LuiafkGlobalNPC : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        switch (npc.type)
        {
            case 113:
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LootMagnet>(), 2));
                break;
            case 370:
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ManaEssence>(), 2));
                break;
            case 398:
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MagicEssence>(), 2));
                break;
            case 262:
                npcLoot.Add(ItemDropRule.Common(ItemID.ChlorophyteOre, 2, 100, 150));
                break;
        }
    }
    public override void ModifyShop(NPCShop shop)
    {
        if (shop.NpcType == NPCID.TravellingMerchant)
        {
            shop.Add<MoneyCollector>();
            shop.Add(new Item(ModContent.ItemType<MoneyCollector>()) {shopCustomPrice = 200 });
        }
        if (shop.NpcType == NPCID.TravellingMerchant)
        {
            if (Main.bloodMoon || Main.eclipse)
            {
                shop.Add(ItemID.PurpleSolution);
            }
            else
            {
                shop.Add(ItemID.RedSolution);
            }
            if (!WorldGen.crimson)
            {
                shop.Add(ItemID.FleshCloningVaat);
            }
        }
    }          
       public override bool InstancePerEntity
    {
        get
        {
            return true;
        }
    }

    public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
    {
        spawnRate = (int)(float)(spawnRate / player.GetModPlayer<LuiafkPlayer>().SpawnRateMultiplier);
        maxSpawns = (int)(float)(maxSpawns * player.GetModPlayer<LuiafkPlayer>().MaxSpawnsMultiplier);
    }
}