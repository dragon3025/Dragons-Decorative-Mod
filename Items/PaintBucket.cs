using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class PaintBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Paint Bucket");
            // Tooltip.SetDefault("Try painting it");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 0, 5);
            Item.createTile = ModContent.TileType<Tiles.PaintBucket>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().PaintBucket)
            {
                return;
            }

            int[] paints = new int[]
            {
                1073,
                1074,
                1075,
                1076,
                1077,
                1078,
                1079,
                1080,
                1081,
                1082,
                1083,
                1084,
                1097,
                1098,
                1099,
                1966
            };

            foreach (int i in paints)
            {
                Recipe recipe = Recipe.Create(Type);
                recipe.AddIngredient(i);
                recipe.Register();
            }
        }
    }
}