using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DragonsDecorativeMod.Items
{
    public class LargeKeg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Large Keg");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 22;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.sellPrice(0, 0, 1, 80);
			Item.createTile = ModContent.TileType<Tiles.LargeKeg>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Wood, 21)
			  .AddTile(TileID.Sawmill)
			  .Register();

			Recipe recipe = Recipe.Create(ModContent.ItemType<Items.LargeKegRotated>());
			recipe.AddIngredient(this);
			recipe.Register();
		}
	}
}