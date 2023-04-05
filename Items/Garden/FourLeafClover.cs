using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    public class FourLeafClover : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Four-Leaf Clover");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 30;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 1);
            Item.createTile = ModContent.TileType<Tiles.Garden.FourLeafClover>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().Clover)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ModContent.ItemType<Items.Garden.Clover>())
              .Register();
        }
    }
}
