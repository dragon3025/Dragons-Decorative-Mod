using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    public class SingleTilePlant2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Single-Tile Deathbell Plant");
            // Tooltip.SetDefault("Fits in a 1x1 Space");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 1, 50);
            Item.createTile = ModContent.TileType<Tiles.Garden.SingleTilePlant>();
            Item.placeStyle = 2;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().Plants)
            {
                return;
            }

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Plant2>())
                .Register();
        }
    }
}
