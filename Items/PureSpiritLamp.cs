using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class PureSpiritLamp : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Pure Spirit Lamp");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 18;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.LightRed;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 74);
            Item.createTile = ModContent.TileType<Tiles.PureSpiritLamp>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().PureSpiritLamp)
            {
                return;
            }

            CreateRecipe()
                .AddIngredient(ItemID.DjinnLamp)
                .AddIngredient(ItemID.SoulofLight, 12)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}