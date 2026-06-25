using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Natural
{
    public class FakeLarva : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 28;
            Item.rare = ItemRarityID.Blue;
            Item.createTile = TileType<Tiles.Natural.FakeLarva>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Natural>().FakeLarva)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Abeemination);
            recipe.AddIngredient(ItemID.BeeWax);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.AddCondition(Condition.InGraveyard);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}