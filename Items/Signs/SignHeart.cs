using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Signs
{
    public class SignHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heart Sign");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.Signs.SignHeart>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddRecipeGroup(RecipeGroupID.Wood, 6)
			  .AddTile(TileID.Sawmill)
			  .Register();
		}
	}
}