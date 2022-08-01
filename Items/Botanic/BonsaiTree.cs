using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Botanic
{
    public class BonsaiTree : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bonsai Tree");
            Tooltip.SetDefault("Think only tree");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 3);
            Item.createTile = ModContent.TileType<Tiles.Botanic.BonsaiTree>();
        }
    }
}
