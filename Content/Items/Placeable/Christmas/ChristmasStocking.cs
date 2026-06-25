using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class ChristmasStocking : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 20;
            Item.height = 28;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 10);
            Item.createTile = ModContent.TileType<Tiles.Christmas.ChristmasStocking>();
            Item.mech = true;
        }
    }
}