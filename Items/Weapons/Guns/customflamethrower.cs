using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMOD.Items           //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class CustomFlamethrower : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Custom Flamethrower";   //the name displayed when hovering over the Weapon ingame.
            item.damage = 19;  //The damage stat for the Weapon.
            item.ranged = true;    //This defines if it does Ranged damage and if its effected by Ranged increasing Armor/Accessories.
            item.width = 42;  //The size of the width of the hitbox in pixels.
            item.height = 16;    //The size of the height of the hitbox in pixels.
            item.toolTip = "This is a custom Flamethrower";  //The description of the Weapon shown when hovering over the Weapon ingame.
            item.toolTip2 = "50% chance to not consume gel";   //The second description of the Weapon shown when hovering over the Weapon ingame.
            item.useTime = 6;   //How fast the Weapon is used.
            item.useAnimation = 20;     //How long the Weapon is used for.
            item.useStyle = 5;   //The way your Weapon will be used, 1 is the regular sword swing for example
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3.25f;  //The knockback stat of your Weapon.
            item.UseSound = SoundID.Item34; //The sound played when using your Weapon
            item.value = Item.buyPrice(0, 10, 0, 0); //	How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 6;   //The color the title of your Weapon when hovering over it ingame   
            item.autoReuse = true;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("FlamethrowerProj");   //This defines what type of projectile this weapon will shot	
            item.shootSpeed = 4.5f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            item.useAmmo = AmmoID.Gel; //This defines what ammo this weapon should use.
        }

        public override bool ConsumeAmmo(Player player) //this is where you can modify the ammo consuming
        {
            return Main.rand.NextFloat() > .50f;//this make so the weapon has 50% chance to not consume ammo, in this case gel
        }
    }
}