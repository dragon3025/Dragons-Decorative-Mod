using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecor.Items.Natural.Ambient
{
    public class LargeGoldCoinStash : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Gold Coin Stash");
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
            Item.DefaultToPlaceableTile(186, 20);
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 20 + Main.rand.Next(2);
            return true;
        }

        public override void AddRecipes()
        {
                CreateRecipe()
                  .AddIngredient(ItemID.StoneBlock, 20)
                  .AddIngredient(ItemID.GoldCoin, 20)
                  .AddTile(TileID.HeavyWorkBench)
                  .AddCondition(Recipe.Condition.InGraveyardBiome)
                  .Register();
        }
    }
}