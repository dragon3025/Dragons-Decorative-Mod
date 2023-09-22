using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    [LegacyName("TrellisVines")]
    [LegacyName("TrellisFlowerVines")]
    [LegacyName("WallVines")]
    [LegacyName("WallFlowerVines")]

    public class Vines : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Wall Vines");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Garden.Vines>();
            Item.placeStyle = 0;
            Item.rare = ItemRarityID.White;
        }

        public override bool? UseItem(Player player)
        {
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Garden.Vines)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Garden.Vines>());
            recipe.AddIngredient(ItemID.VineRope);
            recipe.AddTile(TileID.WorkBenches);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(
                Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
