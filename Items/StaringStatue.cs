using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DragonsDecorativeMod.Items
{
    public class StaringStatue : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ned the Nosey");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 32;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
			Item.value = 0;
			Item.createTile = ModContent.TileType<Tiles.StaringStatue>();
			Item.placeStyle = 0;
		}
	}
}