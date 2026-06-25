using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class MannequinHead : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 20;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.createTile = TileType<Tiles.Other.MannequinHead>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().MannequinHead)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Sawmill);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 6;
        }
    }
}