using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class PaintBottleSingle : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Paint Bottle");
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
            Item.value = Item.buyPrice(0, 0, 25);
            Item.createTile = ModContent.TileType<Tiles.PaintBottleSingle>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().PaintBottle)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ModContent.ItemType<PaintBottleSingle>(), 2);
            recipe.AddIngredient(ModContent.ItemType<PaintBottleDouble>());
            recipe.Register();
        }
    }
}