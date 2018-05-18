using Terraria.ID;
using Terraria.ModLoader;

namespace Megaloguns.Items
{
	public class Dragonblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragonblade");
			Tooltip.SetDefault("Ryūjin no ken wo kurae!);
		}
		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 2;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = -1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.DragonMark, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
