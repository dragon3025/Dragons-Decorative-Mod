using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.SmallB
{
    public class BrokenArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Arrow");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.SmallB>();
            Item.placeStyle = 13;
        }

        public override void OnConsumeItem(Player player)
        {
            Item.placeStyle = 13 + Main.rand.Next(3);
            base.OnConsumeItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.WoodenArrow)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}