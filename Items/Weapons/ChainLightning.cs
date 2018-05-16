using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraWeapons.Items
{
	public class LightningBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightning Orb");
			Tooltip.SetDefault("Fires a ball of lightning that damages groups of enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 80;
			item.magic = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 2;
			item.mana = 3;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.shootspeed = 6f;
			item.shoot = mod.ProjectileType("LightningBall");

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
