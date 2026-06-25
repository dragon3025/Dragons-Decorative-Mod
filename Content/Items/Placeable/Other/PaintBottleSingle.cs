using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class PaintBottleSingle : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 16;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 25);
            Item.createTile = TileType<Tiles.Other.PaintBottleSingle>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().PaintBottle)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemType<PaintBottleDouble>());
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 10;
        }
    }
}