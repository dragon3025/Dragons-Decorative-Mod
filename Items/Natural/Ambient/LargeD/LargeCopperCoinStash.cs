﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeD
{
    public class LargeCopperCoinStash : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Copper Coin Stash");
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
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeD>();
            Item.placeStyle = 16;
        }

        public override void OnConsumeItem(Player player)
        {
            Item.placeStyle = 16 + Main.rand.Next(2);
            base.OnConsumeItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.StoneBlock, 20)
              .AddIngredient(ItemID.CopperCoin, 20)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}