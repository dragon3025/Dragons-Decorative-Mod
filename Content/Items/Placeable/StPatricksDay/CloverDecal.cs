using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.StPatricksDay
{
    public class CloverDecal : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 30;
            Item.height = 30;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 0, 50);
            Item.createTile = TileType<Tiles.StPatricksDay.CloverDecal>();
        }
    }
}