using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraSwords.Items
{
	public class WTGS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WTGS");
			Tooltip.SetDefault("What The Giant Sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 800;
			item.height = 800;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddIngredient(ItemID.LightSoul, 10);
			recipe.AddIngredient(ItemID.Ectoplasm, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
