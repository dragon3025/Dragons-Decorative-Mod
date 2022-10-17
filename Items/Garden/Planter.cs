using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    public class Planter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planter");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 0, 80);
            Item.createTile = ModContent.TileType<Tiles.Garden.Planter>();
            Item.placeStyle = 0;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().Planters)
                return;
            CreateRecipe()
                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}
