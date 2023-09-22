using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.StPatricksDay
{
    public class BagOGreen : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.width = 26;
            Item.height = 34;
            Item.rare = ItemRarityID.White;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            if (GetInstance<DragonsDecoModConfig>().StPatricksDay.PaintingLuringToGold)
            {
                itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemType<LuringToGold>(), 10));
            }

            if (GetInstance<DragonsDecoModConfig>().Garden.Clover)
            {
                IItemDropRule[] cloverDecals = new IItemDropRule[]
                {
                    ItemDropRule.NotScalingWithLuck(ItemType<CloverDecal>()),
                    ItemDropRule.NotScalingWithLuck(ItemType<FourLeafCloverDecal>())
                };
                itemLoot.Add(new OneFromRulesRule(1, cloverDecals));
            }
            else
            {
                itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.CopperCoin));
            }
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().StPatricksDay.CloverDecal && !GetInstance<DragonsDecoModConfig>().StPatricksDay.PaintingLuringToGold)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<StPatricksDay.BagOGreen>());
            recipe.AddIngredient(ItemID.GreenThread);
            recipe.AddIngredient(ItemID.PixieDust);
            recipe.AddTile(TileID.Loom);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
