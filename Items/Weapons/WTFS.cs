using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraSwords.Items
{
	public class WTFS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WTFS");
			Tooltip.SetDefault("What The F***ing Sword!!!");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 1600;
			item.height = 1600;
			item.useTime = 80;
			item.useAnimation = 80;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 50000;
			item.rare = 14;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1998);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
