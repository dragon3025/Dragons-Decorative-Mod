using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Easter
{
    public class EasterEgg : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 20;
            Item.height = 26;
            Item.rare = ItemRarityID.White;
            Item.createTile = ModContent.TileType<Tiles.Easter.EasterEgg>();
            Item.value = Item.sellPrice(0, 0, 0, 60);
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 8;
        }
    }
}