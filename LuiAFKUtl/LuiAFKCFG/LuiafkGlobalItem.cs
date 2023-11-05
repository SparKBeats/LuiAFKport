using Terraria;
using Terraria.ModLoader;

namespace LuiAFKUtl.LuiAFKCFG;

public class LuiafkGlobalItem : GlobalItem
{

    //public override bool ConsumeItem(Item item, Player player)
    //{
    //if (item.damage > 0 && (item.DamageType == DamageClass.Throwing) && item.stack >= 999)
    //{
    //return false;
    //}
    //if (item.damage > 0 && item.stack >= 3996)
    //{
    //return false;
    //}
    //if (item.healLife > 0 && item.stack >= 90)
    //{
    //return false;
    //}
    //if (item.healMana > 0 && item.stack >= 225)
    //{
    //return false;
    //}
    //if (item.buffType > 0 && item.stack >= 30)
    //{
    //return false;
    //}
    //return true;
    //}
    public override void UpdateInventory(Item item, Player player)
    {
        Item[] items = player.inventory;
        //for (int i = 0; i < items.Length; i++)
        //{
        //item = items[i];
        //if (item.consumable && item.stack >= 30 && !player.HasBuff(item.buffType))
        //{
        //Main.buffNoTimeDisplay[item.buffType] = true;
        //player.AddBuff(item.buffType, 10);
        //}

        //}
        items = player.bank.item;
        for (int i = 0; i < items.Length; i++)
        {
            int type = items[i].type;
            if (type == 3124 || type == 3123 || type == 395 || type == 17 || type == 709)
            {
                player.accWatch = 3;
            }
            else
            {
                if (player.accWatch < 2 && (type == 708 || type == 16))
                {
                    player.accWatch = 2;
                    continue;
                }
                if (player.accWatch < 1 && (type == 707 || type == 15))
                {
                    player.accWatch = 1;
                    continue;
                }
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 393)
            {
                player.accCompass = 1;
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 18)
            {
                player.accDepthMeter = 1;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3096)
            {
                player.accCalendar = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3037)
            {
                player.accWeatherRadio = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3120)
            {
                player.accFishFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3102)
            {
                player.accOreFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3099)
            {
                player.accStopwatch = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3119)
            {
                player.accDreamCatcher = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3095)
            {
                player.accJarOfSouls = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3118)
            {
                player.accCritterGuide = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3084)
            {
                player.accThirdEye = true;
            }
            //item = items[i];
            //if (item.consumable && item.stack >= 30 && !player.HasBuff(item.buffType))
            //{
            //Main.buffNoTimeDisplay[item.buffType] = true;
            //player.AddBuff(item.buffType, 10);
            //}
        }
        items = player.bank2.item;
        for (int i = 0; i < items.Length; i++)
        {
            int type = items[i].type;
            if (type == 3124 || type == 3123 || type == 395 || type == 17 || type == 709)
            {
                player.accWatch = 3;
            }
            else
            {
                if (player.accWatch < 2 && (type == 708 || type == 16))
                {
                    player.accWatch = 2;
                    continue;
                }
                if (player.accWatch < 1 && (type == 707 || type == 15))
                {
                    player.accWatch = 1;
                    continue;
                }
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 393)
            {
                player.accCompass = 1;
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 18)
            {
                player.accDepthMeter = 1;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3096)
            {
                player.accCalendar = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3037)
            {
                player.accWeatherRadio = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3120)
            {
                player.accFishFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3102)
            {
                player.accOreFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3099)
            {
                player.accStopwatch = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3119)
            {
                player.accDreamCatcher = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3095)
            {
                player.accJarOfSouls = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3118)
            {
                player.accCritterGuide = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3084)
            {
                player.accThirdEye = true;
            }
            //item = items[i];
            //if (item.consumable && item.stack >= 30 && !player.HasBuff(item.buffType))
            //{
            //Main.buffNoTimeDisplay[item.buffType] = true;
            //player.AddBuff(item.buffType, 10);
            //}
        }
        items = player.bank3.item;
        for (int i = 0; i < items.Length; i++)
        {
            int type = items[i].type;
            if (type == 3124 || type == 3123 || type == 395 || type == 17 || type == 709)
            {
                player.accWatch = 3;
            }
            else
            {
                if (player.accWatch < 2 && (type == 708 || type == 16))
                {
                    player.accWatch = 2;
                    continue;
                }
                if (player.accWatch < 1 && (type == 707 || type == 15))
                {
                    player.accWatch = 1;
                    continue;
                }
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 393)
            {
                player.accCompass = 1;
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 18)
            {
                player.accDepthMeter = 1;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3096)
            {
                player.accCalendar = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3037)
            {
                player.accWeatherRadio = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3120)
            {
                player.accFishFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3102)
            {
                player.accOreFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3099)
            {
                player.accStopwatch = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3119)
            {
                player.accDreamCatcher = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3095)
            {
                player.accJarOfSouls = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3118)
            {
                player.accCritterGuide = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3084)
            {
                player.accThirdEye = true;
            }
            //item = items[i];
            //if (item.consumable && item.stack >= 30 && !player.HasBuff(item.buffType))
            //{
            //Main.buffNoTimeDisplay[item.buffType] = true;
            //player.AddBuff(item.buffType, 10);
            //}
        }
        items = player.bank4.item;
        for (int i = 0; i < items.Length; i++)
        {
            int type = items[i].type;
            if (type == 3124 || type == 3123 || type == 395 || type == 17 || type == 709)
            {
                player.accWatch = 3;
            }
            else
            {
                if (player.accWatch < 2 && (type == 708 || type == 16))
                {
                    player.accWatch = 2;
                    continue;
                }
                if (player.accWatch < 1 && (type == 707 || type == 15))
                {
                    player.accWatch = 1;
                    continue;
                }
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 393)
            {
                player.accCompass = 1;
            }
            if (type == 3124 || type == 3123 || type == 395 || type == 18)
            {
                player.accDepthMeter = 1;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3096)
            {
                player.accCalendar = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3037)
            {
                player.accWeatherRadio = true;
            }
            if (type == 3124 || type == 3123 || type == 3036 || type == 3120)
            {
                player.accFishFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3102)
            {
                player.accOreFinder = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3099)
            {
                player.accStopwatch = true;
            }
            if (type == 3124 || type == 3123 || type == 3121 || type == 3119)
            {
                player.accDreamCatcher = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3095)
            {
                player.accJarOfSouls = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3118)
            {
                player.accCritterGuide = true;
            }
            if (type == 3124 || type == 3123 || type == 3122 || type == 3084)
            {
                player.accThirdEye = true;
            }
            //item = items[i];
            //if (item.consumable && item.stack >= 30 && !player.HasBuff(item.buffType))
            //{
            //Main.buffNoTimeDisplay[item.buffType] = true;
            //player.AddBuff(item.buffType, 10);
            //}
        }
    }
}

