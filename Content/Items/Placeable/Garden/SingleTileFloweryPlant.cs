using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class SingleTileFloweryPlant : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 30;
            Item.height = 30;
            Item.value = Item.buyPrice(0, 1, 50);
            Item.createTile = TileType<Tiles.Garden.SingleTileFloweryPlant>();
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Garden>().Plants)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemType<FloweryPlant>());
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
