using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DragonsDecorativeMod.Items
{
    public class MedusaWatching : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Medusa Watching");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 42;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.Orange;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = Item.buyPrice(0, 0, 10);
			Item.createTile = ModContent.TileType<Tiles.MedusaWatching>();
			Item.placeStyle = 0;
		}
	}
}