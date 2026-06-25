using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class Globe : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 24;
            Item.height = 28;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 10);
            Item.createTile = ModContent.TileType<Tiles.Other.Globe>();
        }
    }
}