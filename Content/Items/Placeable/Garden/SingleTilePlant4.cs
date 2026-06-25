using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class SingleTilePlant4 : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 32;
            Item.value = Item.buyPrice(0, 1, 50);
            Item.createTile = TileType<Tiles.Garden.SingleTilePlant>();
            Item.placeStyle = 6;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Plants)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemType<Plant4>());
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
