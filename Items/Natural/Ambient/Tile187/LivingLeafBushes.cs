using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.Tile187
{
    public class LivingLeafBushes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Living Leaf Bushes");
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
            Item.DefaultToPlaceableTile(187, 50);
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 50 + Main.rand.Next(2);
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.Wood, 20)
              .AddIngredient(ItemID.Worm, 5) //TO-DO Temporary, until the tile style bug is fixed
              .AddTile(TileID.LivingLoom)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}