using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DragonsDecorativeMod.Items
{
    public class SkeletonModel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skeleton Model");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 54;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.Orange;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.sellPrice(0, 0, 11, 80);
			Item.createTile = ModContent.TileType<Tiles.SkeletonModel>();
			Item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			  .AddIngredient(ItemID.Bone, 206)
			  .AddRecipeGroup(RecipeGroupID.IronBar)
			  .AddTile(TileID.HeavyWorkBench)
			  .Register();
		}
	}
}