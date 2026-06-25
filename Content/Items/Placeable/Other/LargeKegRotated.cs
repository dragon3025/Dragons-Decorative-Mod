using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class LargeKegRotated : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 22;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 1, 80);
            Item.createTile = TileType<Tiles.Other.LargeKegRotated>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().LargeKeg)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            Recipe recipe1 = recipe.Clone();

            recipe.AddRecipeGroup(RecipeGroupID.Wood, 21);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar, 1);
            recipe.AddTile(TileID.Sawmill);
            recipe.Register();

            recipe1.ReplaceResult(ItemType<LargeKeg>());
            recipe1.AddIngredient(this);
            recipe1.Register();
        }
    }
}
