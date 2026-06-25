using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class PeacefulPlanteraBulb : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 28;
            Item.rare = ItemRarityID.Lime;
            Item.value = Item.sellPrice(0, 0, 2);
            Item.createTile = TileType<Tiles.Natural.PeacefulPlanteraBulb>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().PeacefulPlanteraBulb)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.ChlorophyteOre, 10);
            recipe.AddTile(TileID.CrystalBall);
            recipe.AddCondition(Condition.InGraveyard);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
