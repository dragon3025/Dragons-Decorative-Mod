using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class StaringStatue : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 22;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(0, 0, 0, 60);
            Item.createTile = ModContent.TileType<Tiles.Other.StaringStatue>();
        }
    }
}