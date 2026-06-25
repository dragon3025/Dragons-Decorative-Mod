using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class MedusaWatching : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 42;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(0, 0, 2);
            Item.createTile = ModContent.TileType<Tiles.Other.MedusaWatching>();
        }
    }
}