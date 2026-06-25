using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class ThreadPlaceable : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 28;
            Item.height = 24;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 4);
            Item.createTile = TileType<Tiles.Other.ThreadPlaceable>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Christmas>().LightPaintable)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            CraftingKey.SetRequirements(ref recipe);
            Recipe recipe1 = recipe.Clone();
            Recipe recipe2 = recipe.Clone();

            recipe.AddIngredient(ItemID.BlackThread);
            recipe.Register();

            recipe1.AddIngredient(ItemID.GreenThread);
            recipe1.Register();

            recipe2.AddIngredient(ItemID.PinkThread);
            recipe2.Register();
        }
    }
}