using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class GolfCart : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Golf Cart");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Yellow;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 10);
            Item.createTile = ModContent.TileType<Tiles.GolfCart>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Other.GolfCart)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<GolfCart>());
            recipe.AddIngredient(ItemID.GolfCart);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();

            recipe = Recipe.Create(ItemID.GolfCart);
            recipe.AddIngredient(this);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}