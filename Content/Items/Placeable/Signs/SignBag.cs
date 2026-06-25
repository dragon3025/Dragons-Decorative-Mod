using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Signs
{
    [LegacyName("SignWeightingScale")]

    public class SignBag : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Signs.SignBag>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Signs>().SignBag)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 6);
            recipe.AddTile(TileID.Sawmill);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}