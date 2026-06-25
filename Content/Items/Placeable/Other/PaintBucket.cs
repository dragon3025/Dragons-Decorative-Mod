using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class PaintBucket : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 26;
            Item.height = 24;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 5);
            Item.createTile = TileType<Tiles.Other.PaintBucket>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().PaintBucket)
            {
                return;
            }

            int[] paints =
            [
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
            ];

            foreach (int i in paints)
            {
                Recipe recipe = Recipe.Create(Type);
                recipe.AddIngredient(i);
                CraftingKey.SetRequirements(ref recipe);
                recipe.Register();
            }
        }
    }
}