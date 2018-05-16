using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Megaloguns
{
    public class TimeTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Reverses some of the damage done by weathering on objects.");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.maxStack = 999;
            item.value = 5000;
            item.rare = 13;
            item.UseSound = SoundID.Item1;
            item.createTile = TileID.TimeTile
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}
