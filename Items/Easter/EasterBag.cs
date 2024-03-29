﻿using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Easter
{
    public class EasterBag : ModItem
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
            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ItemType<EasterBasket>(), 5));
            IItemDropRule[] easterEggs = new IItemDropRule[]
            {
                ItemDropRule.NotScalingWithLuck(ItemType<EasterEgg>(), 1, 2, 5),
                ItemDropRule.NotScalingWithLuck(ItemType<EasterEggSingleColor>(), 1, 2, 5),
                ItemDropRule.NotScalingWithLuck(ItemType<PlasticEgg>(), 1, 2, 5)
            };
            itemLoot.Add(new OneFromRulesRule(1, easterEggs));
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Easter.EasterBasket && !GetInstance<DragonsDecoModConfig>().Easter.EasterEggs)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Easter.EasterBag>());
            recipe.AddIngredient(ItemID.PinkThread);
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
