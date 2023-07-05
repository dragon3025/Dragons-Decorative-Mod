using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Christmas
{
    public class SnowmanLeft : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Snowman Left");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 25);
            Item.createTile = ModContent.TileType<Tiles.Christmas.SnowmanLeft>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Christmas.Snowman)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<SnowmanRight>());
            recipe.AddIngredient(this);
            recipe.Register();
        }
    }
}