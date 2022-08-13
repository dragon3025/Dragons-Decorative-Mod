using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Pots
{
    public class CorruptionPot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corruption Pot");
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
            Item.placeStyle = 48;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = Main.rand.Next(48, 57);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.LesionBlock, 5)
              .AddIngredient(ItemID.ClayBlock, 5)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}