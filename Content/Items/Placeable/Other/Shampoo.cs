using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class Shampoo : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 12;
            Item.height = 26;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(0, 0, 25);
            Item.createTile = ModContent.TileType<Tiles.Other.Shampoo>();
        }

        public override void UpdateInventory(Player player)
        {
            //In 1.4.5+, see if there's support for custom FlexibleTileWand types.
            Item.placeStyle = System.Math.Abs(Player.FlexibleWandCycleOffset) % 8;
        }
    }
}