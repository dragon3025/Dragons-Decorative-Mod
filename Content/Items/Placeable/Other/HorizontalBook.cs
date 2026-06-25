using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class HorizontalBook : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 28;
            Item.height = 30;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 3);
            Item.createTile = TileType<Tiles.Other.HorizontalBook>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Other>().HorizontalBook)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            Recipe recipe1 = recipe.Clone();
            recipe1.AddIngredient(this);
            Recipe recipe2 = recipe1.Clone();

            recipe.AddIngredient(ItemID.Book);
            recipe.Register();

            recipe1.ReplaceResult(ItemID.Book);
            recipe1.Register();

            recipe2.ReplaceResult(ItemType<HorizontalBooksStacked>());
            recipe2.Register();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 14;
        }
    }
}