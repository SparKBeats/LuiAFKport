using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LuiAFKUtlUtl
{
    public class LuiAFKUtlUtl : Mod
    {
        public const string ASSET_PATH = "LuiAFKUtlUtl/Assets/";

        public override void AddRecipeGroups()/* tModPorter Note: Removed. Use ModSystem.AddRecipeGroups */
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37"), new int[]
            {
                ItemID.VileMushroom,
                ItemID.ViciousMushroom
            });
            RecipeGroup.RegisterGroup("EvilMushrooms", group);
            RecipeGroup group1 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37"), new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("EvilBars", group1);
            RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37"), new int[]
            {
                ItemID.ViciousPowder,
                ItemID.VilePowder
            });
            RecipeGroup.RegisterGroup("EvilPowders", group2);
        }
    }
}