using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Content.Items.Placeable.Other
{
    public class BestiaryTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.KingSlimeTrophy);
            Item.placeStyle = 0;
            Item.value = Item.buyPrice(1);
            Item.rare = ItemRarityID.Cyan;
            Item.createTile = ModContent.TileType<Tiles.Other.BestiaryTrophy>();
        }
    }
}