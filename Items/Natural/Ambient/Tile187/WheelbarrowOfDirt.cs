using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.Tile187
{
    public class WheelbarrowOfDirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wheelbarrow of Dirt");
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
            Item.createTile = ModContent.TileType<Tiles.Natural.AmbientObjectsC>();
            Item.placeStyle = 9;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.DirtBlock, 20)
              .AddRecipeGroup(RecipeGroupID.IronBar, 5)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}