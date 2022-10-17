using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class HorizontalBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Horizontal Book");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 30;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 3);
            Item.createTile = ModContent.TileType<Tiles.HorizontalBook>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().HorizontalBook)
                return;
            CreateRecipe()
              .AddIngredient(ItemID.Book)
              .Register();

            Recipe recipe = Recipe.Create(ItemID.Book);
            recipe.AddIngredient(this);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<Items.HorizontalBooksStacked>());
            recipe.AddIngredient(this);
            recipe.Register();
        }
    }
}