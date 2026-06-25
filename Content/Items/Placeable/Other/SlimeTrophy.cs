using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class SlimeTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.KingSlimeTrophy);
            Item.placeStyle = 0;
            Item.createTile = ModContent.TileType<Tiles.Other.SlimeTrophy>();
        }
    }
}