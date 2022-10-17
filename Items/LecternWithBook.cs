using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class LecternWithBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lectern with Book");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 40;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Lectern>();
            Item.placeStyle = 1;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().Lectern)
                return;

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Items.Lectern>())
                .AddIngredient(ItemID.Book)
                .Register();
        }
    }
}