using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.StPatricksDay
{
    public class BagOGreen : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Wood);
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
            if (GetInstance<Configuration.StPatricksDay>().PaintingLuringToGold)
            {
                itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemType<LuringToGold>(), 10));
            }

            if (GetInstance<Configuration.Garden>().Clover)
            {
                IItemDropRule[] cloverDecals =
                [
                    ItemDropRule.NotScalingWithLuck(ItemType<CloverDecal>()),
                    ItemDropRule.NotScalingWithLuck(ItemType<FourLeafCloverDecal>())
                ];
                itemLoot.Add(new OneFromRulesRule(1, cloverDecals));
            }
            else
            {
                itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemID.CopperCoin));
            }
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.StPatricksDay>().CloverDecal && !GetInstance<Configuration.StPatricksDay>().PaintingLuringToGold)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.GreenThread);
            recipe.AddIngredient(ItemID.PixieDust);
            recipe.AddTile(TileID.Loom);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
