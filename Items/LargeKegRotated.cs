using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class LargeKegRotated : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Large Rotated Keg");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 1, 80);
            Item.createTile = ModContent.TileType<Tiles.LargeKegRotated>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Other.LargeKeg)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<LargeKegRotated>());
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 21);
            recipe.AddTile(TileID.Sawmill);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<Items.LargeKeg>());
            recipe.AddIngredient(this);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
