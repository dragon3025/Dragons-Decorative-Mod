using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class CandyCane : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 20;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 10);
            Item.createTile = ModContent.TileType<Tiles.Christmas.CandyCane>();
            Item.mech = true;
        }
    }
}