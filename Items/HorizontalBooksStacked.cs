using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items
{
    public class HorizontalBooksStacked : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Horizontal Book Stacked");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.sellPrice(0, 3);
			Item.createTile = ModContent.TileType<Tiles.HorizontalBooksStacked>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Book)
			  .Register();

			Recipe recipe = Recipe.Create(ItemID.Book);
			recipe.AddIngredient(this);
			recipe.Register();

			recipe = Recipe.Create(ModContent.ItemType<Items.HorizontalBook>());
			recipe.AddIngredient(this);
			recipe.Register();
		}
	}
}