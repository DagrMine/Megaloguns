using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraWeapons.Items
{
	public class Sunfury : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sunfury");
			Tooltip.SetDefault("Beep beep i'm a sheep.");
		}
		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}