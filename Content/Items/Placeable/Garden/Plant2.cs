using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class Plant2 : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 26;
            Item.value = Item.buyPrice(0, 1, 50);
            Item.createTile = TileType<Tiles.Garden.Plant>();
            Item.placeStyle = 2;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Plants)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemType<SingleTilePlant2>());
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
