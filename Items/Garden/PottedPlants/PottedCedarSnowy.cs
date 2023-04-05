using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Garden.PottedPlants
{
    public class PottedCedarSnowy : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Potted Snowy Cedar");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 60);
            Item.createTile = ModContent.TileType<Tiles.Garden.PottedPlants.PottedTrees>();
        }
    }
}
