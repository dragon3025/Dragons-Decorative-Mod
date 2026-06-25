using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Garden.Mushrooms
{
    public class BleedingCrownMushroom : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.buyPrice(0, 0, 1);
            Item.createTile = ModContent.TileType<Tiles.Garden.Mushrooms.BleedingCrownMushroom>();
            Item.rare = ItemRarityID.White;
        }
    }
}
