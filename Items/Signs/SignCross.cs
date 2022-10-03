/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Signs
{
    public class SignCross : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healthy Cross Sign");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 40;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.Signs.SignCross>();
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
*/