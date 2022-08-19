using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FallenLog : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fallen Log");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 48;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.createTile = TileID.FallenLog;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Wood, 20)
			  .AddIngredient(ItemID.PixieDust)
			  .AddTile(TileID.HeavyWorkBench)
			  .AddCondition(Recipe.Condition.InGraveyardBiome)
			  .Register();
		}
	}
}