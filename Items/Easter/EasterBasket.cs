using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Easter
{
    public class EasterBasket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Easter Basket");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 37, 50);
            Item.createTile = ModContent.TileType<Tiles.Easter.EasterBasket>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().EasterBasket)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ModContent.ItemType<Items.Easter.EasterEgg>(), 5)
              .AddIngredient(ItemID.FlowerPacketTallGrass)
              .AddRecipeGroup(RecipeGroupID.Wood)
              .AddTile(TileID.WorkBenches)
              .Register();
        }
    }
}