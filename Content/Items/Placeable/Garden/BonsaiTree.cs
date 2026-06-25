using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class BonsaiTree : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(0, 3);
            Item.createTile = ModContent.TileType<Tiles.Garden.BonsaiTree>();
        }
    }
}
