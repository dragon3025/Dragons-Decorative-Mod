using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Christmas
{
    public class GingerbreadHouse : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 22;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 10);
            Item.createTile = ModContent.TileType<Tiles.Christmas.GingerbreadHouse>();
            Item.mech = true;
        }
    }
}