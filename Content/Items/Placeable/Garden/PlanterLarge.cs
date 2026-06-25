using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class PlanterLarge : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 0, 0, 80);
            Item.createTile = TileType<Tiles.Garden.Planter>();
            Item.placeStyle = 1;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Planters)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.ClayBlock, 20);
            recipe.AddTile(TileID.Furnaces);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
