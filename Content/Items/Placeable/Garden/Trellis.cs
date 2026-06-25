using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    [LegacyName("TrellisEmpty")]

    public class Trellis : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodWall);
            Item.width = 14;
            Item.height = 14;
            Item.createWall = WallType<Walls.Trellis>();
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Trellis)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddRecipeGroup(RecipeGroupID.Wood);
            recipe.AddTile(TileID.Sawmill);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
