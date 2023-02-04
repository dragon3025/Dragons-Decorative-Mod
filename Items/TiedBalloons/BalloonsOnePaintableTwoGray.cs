using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.TiedBalloons
{
    public class BalloonsOnePaintableTwoGray : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Balloons (2 Gray, 1 Paintable)");
            Tooltip.SetDefault("Try painting it");
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
            Item.createTile = ModContent.TileType<Tiles.TiedBalloons.BalloonsOnePaintableTwoGray>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.PartyBundleOfBalloonTile);
            recipe.AddIngredient(ItemID.GrayPaint, 2);
            recipe.Register();
        }
    }
}