using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FakeCrimsonAltar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fake Crimson Altar");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.Natural.FakeCrimsonAltar>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.CrimstoneBlock)
			  .AddTile(TileID.CrystalBall)
			  .AddCondition(Recipe.Condition.InGraveyardBiome)
			  .Register();
		}
	}
}