using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class PureSpiritLamp : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.value = Item.buyPrice(0, 0, 74);
            Item.createTile = ModContent.TileType<Tiles.Other.PureSpiritLamp>();
        }
    }
}
