using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FallenLog : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fallen Log");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = TileID.FallenLog;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Natural.FallenLog)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Natural.FallenLog>());
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.AddCondition(Condition.InGraveyard);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
