using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecor.Items.Natural.Ambient
{
    public class JungleGrassyMudPiles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jungle Grassy MudHeaps");
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
            Item.DefaultToPlaceableTile(187, 3);
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 3 + Main.rand.Next(3);
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.MudBlock, 20)
              .AddIngredient(ItemID.JungleGrassSeeds, 5)
              .AddIngredient(ItemID.Worm, 3)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}