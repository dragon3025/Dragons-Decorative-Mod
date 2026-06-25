using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class FakeDemonAltar : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Natural.FakeDemonAltar>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().AltarsShadowOrbAndCrimsonHeart)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 12);
            recipe.AddTile(TileID.CrystalBall);
            recipe.AddCondition(Condition.InGraveyard);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}