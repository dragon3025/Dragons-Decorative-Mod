using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class Snowman : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 28;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Christmas.Snowman>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Christmas>().Snowman)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.SnowBlock, 30);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 5;
        }
    }
}