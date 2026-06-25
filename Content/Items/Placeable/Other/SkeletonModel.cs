using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class SkeletonModel : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 54;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(0, 0, 0, 10) * 20;
            Item.createTile = TileType<Tiles.Other.SkeletonModel>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().SkeletonModel)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar);
            recipe.AddTile(TileID.HeavyWorkBench);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 3;
        }
    }
}