using LuiAFKUtl.Content.Items.Misc;
using Terraria;
using Terraria.ModLoader;

namespace LuiAFKUtl.LuiAFKCFG;

internal class LuiafkPlayer : ModPlayer
{
    internal bool moneyCollect;
    internal bool UltBattler;
    internal bool UltPeaceful;
    internal PotBuff buffs;
    internal bool holdingFishingRod;
    internal bool unlimitedMana;
    internal float SpawnRateMultiplier = 1f;
    internal float MaxSpawnsMultiplier = 1f;
    public override void PostUpdate()
    {
        if (Player.whoAmI == Main.myPlayer)
        {
            if (moneyCollect)
            {
                MoneyCollector.UpdateCoins(Player);
            }
        }
    }
    private void Reset()
    {
        buffs = PotBuff.None;
        holdingFishingRod = false;
        unlimitedMana = false;
        moneyCollect = false;
    }
    public override void PostUpdateEquips()
    {
        if (UltBattler || UltPeaceful)
        {
            UpdatePotions(Main.CurrentPlayer);
        }
    }
    internal void UpdatePotions(Player player)
    {
        if (UltPeaceful)
        {
            player.ZoneWaterCandle = false;
            player.ZonePeaceCandle = true;
            player.calmed = true;
            player.sunflower = true;
            Player player47 = player;
            player47.moveSpeed += 0.1f;
            Player player48 = player;
            player48.moveSpeed *= 1.1f;
            player.buffImmune[146] = true;
            player.buffImmune[86] = true;
            player.buffImmune[13] = true;
            player.buffImmune[157] = true;
            player.buffImmune[106] = true;
        }
        if (UltBattler)
        {
            player.ZoneWaterCandle = true;
            player.ZonePeaceCandle = false;
            player.calmed = false;
            player.sunflower = false;
            player.buffImmune[146] = true;
            player.buffImmune[157] = true;
            player.buffImmune[106] = true;
            player.buffImmune[86] = true;
            player.buffImmune[13] = true;
        }
    }
}
