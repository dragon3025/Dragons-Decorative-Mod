using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class LightPaintable : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 18;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 5);
            Item.createTile = TileType<Tiles.Christmas.LightPaintable>();
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

            recipe.AddIngredient(ItemID.RedLight);
            recipe.Register();

            recipe1.AddIngredient(ItemID.GreenLight);
            recipe1.Register();

            recipe2.AddIngredient(ItemID.BlueLight);
            recipe2.Register();
        }
    }
}
