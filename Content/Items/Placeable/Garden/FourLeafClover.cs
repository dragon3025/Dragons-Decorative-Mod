using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class FourLeafClover : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 26;
            Item.height = 30;
            Item.value = Item.buyPrice(0, 0, 1);
            Item.createTile = TileType<Tiles.Garden.FourLeafClover>();
        }
    }
}
