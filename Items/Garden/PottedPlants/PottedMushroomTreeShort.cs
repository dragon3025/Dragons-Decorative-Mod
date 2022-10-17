using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Garden.PottedPlants
{
    public class PottedMushroomTreeShort : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potted Short Mushroom Tree");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 30;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 3);
            Item.createTile = ModContent.TileType<Tiles.Garden.PottedPlants.PottedMushroomPlantShort>();
        }
    }
}
