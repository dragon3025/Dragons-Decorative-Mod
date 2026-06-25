using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Easter
{
    public class EasterEggSingleColor : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 20;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.createTile = ModContent.TileType<Tiles.Easter.EasterEggSingleColor>();
            Item.value = Item.sellPrice(0, 0, 0, 60);
        }
    }
}