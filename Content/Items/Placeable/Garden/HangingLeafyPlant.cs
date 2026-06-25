using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden
{
    public class HangingLeafyPlant : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 16;
            Item.height = 36;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 25);
            Item.createTile = ModContent.TileType<Tiles.Garden.HangingPlant>();
            Item.placeStyle = 1;
        }
    }
}