using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraSwords.Items
{
	public class HallowedKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HallowedKatana");
			Tooltip.SetDefault("This is a modded unreleased sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 1;
			item.knockBack = 90;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
