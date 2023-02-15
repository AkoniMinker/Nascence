
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace Nascence.Items
{
	public class FuryPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Fury Pickaxe Axe");
			Tooltip.SetDefault("This is a modded Pickaxe Axe.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
            Item.damage = 200;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 8;
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.crit = 32;
			Item.pick = 200;
			Item.axe = 40;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.SilverFlame);
			}
		}	

		public override void AddRecipes() {
			CreateRecipe()
				.Register();
		}
	}
}