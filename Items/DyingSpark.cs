using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Nascence.Items
{
	public class DyingSpark : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dying Spark");
            Tooltip.SetDefault("This is a basic modded staff.");         
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            Item.staff[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.damage = 200;
			Item.DamageType = DamageClass.Magic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 8;
			Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
			Item.useTurn = false;
			Item.shoot = ProjectileID.InfernoFriendlyBolt;
			Item.shootSpeed = 32f;
			Item.crit = 32;
            Item.mana = 0;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int NumProjectiles = Main.rand.Next(3, 5);

            for (int i = 0; i < NumProjectiles; i++)
            {
                Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));
                newVelocity *= 1f - Main.rand.NextFloat(0.3f);
                Projectile.NewProjectileDirect(source, position, newVelocity / 3, ProjectileID.InfernoFriendlyBolt, damage, knockback, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .Register();
        }
    }
}