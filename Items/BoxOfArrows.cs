using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items
{
    public class BoxOfArrows : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Box of Arrows");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.sellPrice(0, 0, 0, 60);
			Item.createTile = ModContent.TileType<Tiles.BoxOfArrows>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Wood, 4)
			  .AddIngredient(ItemID.WoodenArrow, 30)
			  .AddTile(TileID.WorkBenches)
			  .Register();
		}
	}
}