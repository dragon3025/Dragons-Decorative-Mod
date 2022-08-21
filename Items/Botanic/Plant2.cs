using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Botanic
{
    public class Plant2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deathbell Plant");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 1, 5);
            Item.createTile = ModContent.TileType<Tiles.Botanic.Plant>();
            Item.placeStyle = 1;
        }
    }
}
