using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class Lectern : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Lectern");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 38;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Lectern>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Other.Lectern)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Lectern>());
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
            recipe.AddTile(TileID.Sawmill);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}