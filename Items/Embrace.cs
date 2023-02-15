using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
namespace Nascence.Items
{
	public class Embrace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Embrace");
			Tooltip.SetDefault("This is a basic modded sword.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.damage = 200;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.shoot = ProjectileID.EnchantedBeam;
			Item.shootSpeed = 12f;
			Item.crit = 32;
		}
		public override void AddRecipes()
		{

			Recipe recipe = CreateRecipe();
			recipe.Register();
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.SilverFlame);
			}
		}	
	}
}