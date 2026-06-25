using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden.PottedPlants
{
    public class PottedMushroomTreeTall : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 18;
            Item.height = 32;
            Item.value = Item.buyPrice(0, 3);
            Item.createTile = ModContent.TileType<Tiles.Garden.PottedPlants.PottedMushroomPlantTall>();
        }
    }
}
