using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items
{
    public class MoonGlobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Globe");
            Tooltip.SetDefault("Toss it to change how the moon looks!\n" +
                "'Time for a change of scenery'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item106;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 3);
            Item.DefaultToThrownWeapon(ModContent.ProjectileType<Projectiles.MoonGlobe>(), 20, 8f);
        }
    }
}