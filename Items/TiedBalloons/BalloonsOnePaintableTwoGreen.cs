using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.TiedBalloons
{
    public class BalloonsOnePaintableTwoGreen : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Balloons (2 Green, 1 Paintable)");
            // Tooltip.SetDefault("Try painting it");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 4);
            Item.createTile = ModContent.TileType<Tiles.TiedBalloons.BalloonsOnePaintableTwoGreen>();
        }

        public override void AddRecipes()
        {
            if (GetInstance<DragonsDecoModConfig>().Balloons)
            {
                return;
            }
            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.PartyBundleOfBalloonTile);
            recipe.AddIngredient(ItemID.GreenPaint, 2);
            recipe.Register();
        }
    }
}