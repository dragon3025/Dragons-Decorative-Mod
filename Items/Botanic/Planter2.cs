using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Botanic
{
    public class Planter2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planter");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 1, 5);
            Item.createTile = ModContent.TileType<Tiles.Botanic.Planter>();
            Item.placeStyle = 1;
        }
    }
}
