using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural
{
    public class PeacefulPlanteraBulb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Peaceful Plantera Bulb");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.Lime;
			Item.useAnimation = 45;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.buyPrice(0, 0, 10);
			Item.createTile = ModContent.TileType<Tiles.Natural.PeacefulPlanteraBulb>();
		}
	}
}