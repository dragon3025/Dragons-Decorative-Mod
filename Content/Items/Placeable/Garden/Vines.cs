using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    [LegacyName("TrellisVines")]
    [LegacyName("TrellisFlowerVines")]
    [LegacyName("WallVines")]
    [LegacyName("WallFlowerVines")]

    public class Vines : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 16;
            Item.height = 16;
            Item.createTile = TileType<Tiles.Garden.Vines>();
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Vines)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.VineRope);
            recipe.AddTile(TileID.WorkBenches);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
