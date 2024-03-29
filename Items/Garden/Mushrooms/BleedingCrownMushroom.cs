using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Garden.Mushrooms
{
    public class BleedingCrownMushroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Bleeding Crown Mushroom");
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
            Item.value = Item.buyPrice(0, 0, 1);
            Item.createTile = ModContent.TileType<Tiles.Garden.Mushrooms.BleedingCrownMushroom>();
            Item.rare = ItemRarityID.White;
        }
    }
}
