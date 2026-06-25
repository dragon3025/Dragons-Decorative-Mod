using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Pets
{
    public class Aquarium : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 5);
            Item.createTile = TileType<Tiles.Pets.Aquarium>();
        }
    }
}