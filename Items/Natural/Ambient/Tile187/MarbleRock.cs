﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.Tile187
{
    public class MarbleRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marble Rock");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 32;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 45;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.DefaultToPlaceableTile(187, 41);
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 41 + Main.rand.Next(6);
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.MarbleBlock, 20)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}