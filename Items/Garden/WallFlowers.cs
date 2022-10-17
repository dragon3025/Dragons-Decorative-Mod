using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    public class WallFlowers : ModItem
    {
        public int styleSecton = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall Flowers");
            Tooltip.SetDefault("Try painting them");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Garden.WallFlowers>();
            Item.placeStyle = 0;
            Item.value = Item.sellPrice(0, 0, 5);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<ABlocksWallsConfig>().WallFlowers)
                return;
            CreateRecipe()
              .AddIngredient(ItemID.FlowerPacketWild, 5)
              .AddTile(TileID.WorkBenches)
              .Register();
        }
    }
}
