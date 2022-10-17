using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class ThreadPlaceable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Placeable Thread");
            Tooltip.SetDefault("Try painting it");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 4);
            Item.createTile = ModContent.TileType<Tiles.ThreadPlaceable>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().ThreadPlaceable)
                return;

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.BlackThread);
            recipe.Register();

            recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.GreenThread);
            recipe.Register();

            recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.PinkThread);
            recipe.Register();
        }
    }
}