using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeB
{
    public class WebCoveredSkeleton : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Web Covered Skeleton");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeB>();
            Item.placeStyle = 9;
        }

        public override void OnConsumeItem(Player player)
        {
            Item.placeStyle = 9;
            if (Main.rand.NextBool(2))
                Item.placeStyle = 13;
            base.OnConsumeItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.Bone, 20)
              .AddIngredient(ItemID.Cobweb, 5)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}