﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecor.Items.Natural.Ambient
{
    public class ToolAndRocks : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tool and Rocks");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 32;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Orange;
            Item.useAnimation = 45;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.DefaultToPlaceableTile(186, 13);
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 13 + Main.rand.Next(3);
            return true;
        }

        public override void AddRecipes()
        {
                CreateRecipe()
                  .AddIngredient(ItemID.StoneBlock, 20)
                  .AddRecipeGroup(RecipeGroupID.IronBar)
                  .AddTile(TileID.HeavyWorkBench)
                  .AddCondition(Recipe.Condition.InGraveyardBiome)
                  .Register();
        }
    }
}