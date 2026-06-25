using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Content.Items.Placeable.Easter
{
    public class EasterBag : ModItem
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
            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemType<EasterBasket>(), 5));
            IItemDropRule[] easterEggs =
            [
                ItemDropRule.NotScalingWithLuck(ItemType<EasterEgg>(), 1, 2, 5),
                ItemDropRule.NotScalingWithLuck(ItemType<EasterEggSingleColor>(), 1, 2, 5),
                ItemDropRule.NotScalingWithLuck(ItemType<PlasticEgg>(), 1, 2, 5)
            ];
            itemLoot.Add(new OneFromRulesRule(1, easterEggs));
        }

        public override void AddRecipes()
        {
            if (!GetInstance<Configuration.Easter>().EasterBasket && !GetInstance<Configuration.Easter>().EasterEggs)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.PinkThread);
            recipe.AddIngredient(ItemID.PixieDust);
            recipe.AddTile(TileID.Loom);
            CraftingKey.SetRequirements(ref recipe);
            recipe.Register();
        }
    }
}
