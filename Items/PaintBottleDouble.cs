using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class PaintBottleDouble : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Double Paint Bottle");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 50);
            Item.createTile = ModContent.TileType<Tiles.PaintBottleDouble>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().PaintBottle)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ModContent.ItemType<PaintBottleSingle>(), 2)
              .Register();
        }
    }
}