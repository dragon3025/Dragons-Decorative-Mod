using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class Easel : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 30;
            Item.height = 48;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Other.Easel>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().Easel)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.Sawmill);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}