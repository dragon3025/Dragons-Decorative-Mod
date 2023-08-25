using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.StPatricksDay
{
    public class LuringToGold : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Luring To Gold");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 5);
            Item.createTile = ModContent.TileType<Tiles.StPatricksDay.LuringToGold>();
            Item.placeStyle = 0;
        }
    }
}