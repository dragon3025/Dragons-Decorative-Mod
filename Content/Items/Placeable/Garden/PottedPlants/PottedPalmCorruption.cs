using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden.PottedPlants
{
    public class PottedPalmCorruption : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 32;
            Item.value = Item.sellPrice(0, 0, 60);
            Item.createTile = ModContent.TileType<Tiles.Garden.PottedPlants.PottedPalmTrees>();
        }
    }
}
