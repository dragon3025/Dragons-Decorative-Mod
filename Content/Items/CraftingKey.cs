using DragonsDecorativeMod.Configuration;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items
{
    public class CraftingKey : ModItem
    {
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            CraftingKeyEnums requireCraftingKey = GetInstance<GeneralConfig>().RequireCraftingKey;

            if (requireCraftingKey == CraftingKeyEnums.Ingredient || requireCraftingKey == CraftingKeyEnums.Both)
            {
                tooltips.Add(new TooltipLine(Mod, "CraftingKeyNotConsumed", DragonsDecorativeMod.GetText("Misc.CraftingKey.NotConsumed")));
            }

            if (requireCraftingKey == CraftingKeyEnums.Tile || requireCraftingKey == CraftingKeyEnums.Both)
            {
                tooltips.Add(new TooltipLine(Mod, "CraftingKeyToggleWithWire", DragonsDecorativeMod.GetText("Misc.CraftingKey.ToggleWithWire")));
            }
        }

        public override void SetDefaults()
        {
            CraftingKeyEnums requireCraftingKey = GetInstance<GeneralConfig>().RequireCraftingKey;

            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.White;
            if (requireCraftingKey == CraftingKeyEnums.Tile || requireCraftingKey == CraftingKeyEnums.Both)
            {
                Item.CloneDefaults(ItemID.WorkBench);
                Item.createTile = TileType<Tiles.CraftingKeyBench>();
                Item.value = 0;
                return;
            }
            Item.maxStack = Item.CommonMaxStack;
        }

        public override void AddRecipes()
        {
            if (GetInstance<GeneralConfig>().RequireCraftingKey != CraftingKeyEnums.Disabled)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Wood);
            recipe.Register();

            recipe = Recipe.Create(ItemID.Wood);
            recipe.AddIngredient(Type);
            recipe.Register();
        }

        private static void DontConsumeCraftingKey(Recipe recipe, int type, ref int amount, bool isDecrafting)
        {
            if (type == ItemType<CraftingKey>())
            {
                amount = 0;
            }
        }

        internal static void SetRequirements(ref Recipe recipe)
        {
            CraftingKeyEnums requireCraftingKey = GetInstance<GeneralConfig>().RequireCraftingKey;

            if (requireCraftingKey == CraftingKeyEnums.Ingredient || requireCraftingKey == CraftingKeyEnums.Both)
            {
                recipe.AddIngredient(ItemType<CraftingKey>());
                recipe.AddConsumeIngredientCallback(DontConsumeCraftingKey);
            }
            if (requireCraftingKey == CraftingKeyEnums.Tile || requireCraftingKey == CraftingKeyEnums.Both)
            {
                recipe.AddTile(TileType<Tiles.CraftingKeyBench>());
            }
        }
    }
}