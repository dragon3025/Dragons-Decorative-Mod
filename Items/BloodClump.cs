using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items
{
    public class BloodClump : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Clump");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.Blue;
		}
    }
}