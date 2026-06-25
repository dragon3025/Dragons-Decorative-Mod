using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden.PottedPlants
{
    public class PottedOasisPlantCorruption : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 24;
            Item.height = 24;
            Item.value = Item.sellPrice(0, 0, 60);
            Item.createTile = ModContent.TileType<Tiles.Garden.PottedPlants.PottedOasisPlants>();
            Item.placeStyle = 7;
        }
    }
}
