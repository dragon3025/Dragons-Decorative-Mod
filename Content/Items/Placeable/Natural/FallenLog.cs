using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class FallenLog : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 48;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileID.FallenLog;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().FallenLog)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.AddCondition(Condition.InGraveyard);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
