using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.Tile187
{
    public class UndergroundCage : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Underground Cage");
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
            Item.DefaultToPlaceableTile(187, 21);
        }

        public override bool? UseItem(Player player)
        {
            if (Main.rand.NextBool(2))
                Item.placeStyle = 21;
            else
                Item.placeStyle = 22;
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddRecipeGroup(RecipeGroupID.Wood, 20)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}