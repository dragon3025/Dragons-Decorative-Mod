using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class FakeCrimsonHeart : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Natural.FakeCrimsonHeart>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().AltarsShadowOrbAndCrimsonHeart)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 8);
            recipe.AddTile(TileID.CrystalBall);
            recipe.AddCondition(Condition.InGraveyard);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}