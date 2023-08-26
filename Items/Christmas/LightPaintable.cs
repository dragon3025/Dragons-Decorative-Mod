using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Christmas
{
    public class LightPaintable : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Cyan Light");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 5);
            Item.createTile = ModContent.TileType<Tiles.Christmas.LightPaintable>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Christmas.LightPaintable)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<LightPaintable>());
            recipe.AddIngredient(ItemID.RedLight);
            recipe.Register();

            recipe = Recipe.Create(ItemType<LightPaintable>());
            recipe.AddIngredient(ItemID.GreenLight);
            recipe.Register();

            recipe = Recipe.Create(ItemType<LightPaintable>());
            recipe.AddIngredient(ItemID.BlueLight);
            recipe.Register();
        }
    }
}