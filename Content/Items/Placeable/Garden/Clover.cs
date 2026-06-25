using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class Clover : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 26;
            Item.height = 30;
            Item.value = Item.buyPrice(0, 0, 1);
            Item.createTile = TileType<Tiles.Garden.Clover>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Clover)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemType<FourLeafClover>());
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
