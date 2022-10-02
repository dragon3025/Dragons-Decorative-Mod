using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items
{
    public class Easel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Easel");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 48;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.Easel>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Wood, 4)
			  .Register();
		}
	}
}