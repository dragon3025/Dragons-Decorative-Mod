using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Easter
{
    public class EasterEgg : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Easter Egg");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Easter.EasterEgg>();
            Item.value = Item.sellPrice(0, 0, 0, 60);
        }
    }
}