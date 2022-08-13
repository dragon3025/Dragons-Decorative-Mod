using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Pots
{
    public class GranitePot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Pot");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.FakePot>();
            Item.placeStyle = 111;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = Main.rand.Next(111, 120);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.ClayBlock, 5)
              .AddIngredient(ItemID.GraniteBlock, 5)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}