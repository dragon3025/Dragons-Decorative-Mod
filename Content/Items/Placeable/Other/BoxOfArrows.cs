using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class BoxOfArrows : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 24;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 60);
            Item.createTile = TileType<Tiles.Other.BoxOfArrows>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().BoxOfArrows)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddIngredient(ItemID.WoodenArrow, 30);
            recipe.AddTile(TileID.WorkBenches);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}