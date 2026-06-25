using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class StepStoolPlaceable : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 28;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 30);
            Item.createTile = TileType<Tiles.Other.StepStoolPlaceable>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().StepStoolPlaceable)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}