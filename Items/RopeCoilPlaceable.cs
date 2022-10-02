using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items
{
    public class RopeCoilPlaceable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Placeable Rope Coil");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 0, 20);
            Item.createTile = ModContent.TileType<Tiles.RopeCoil>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.RopeCoil)
              .Register();

            Recipe recipe = Recipe.Create(ItemID.RopeCoil);
            recipe.AddIngredient(this);
            recipe.Register();
        }
    }
}