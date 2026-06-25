using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class WallFlowers : ModItem
    {
        public int styleSecton = 0;

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 16;
            Item.height = 16;
            Item.createTile = TileType<Tiles.Garden.WallFlowers>();
            Item.value = Item.sellPrice(0, 0, 1);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().WallFlowers)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.FlowerPacketWild, 5);
            recipe.AddTile(TileID.WorkBenches);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
