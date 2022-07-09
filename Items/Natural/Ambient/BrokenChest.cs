using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecor.Items.Natural.Ambient
{
    public class BrokenChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Chest");
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
            Item.DefaultToPlaceableTile(186, 24);
        }

        public override void AddRecipes()
        {
                CreateRecipe()
                  .AddIngredient(ItemID.Chest)
                  .AddIngredient(ItemID.Cobweb)
                  .AddTile(TileID.HeavyWorkBench)
                  .AddCondition(Recipe.Condition.InGraveyardBiome)
                  .Register();
        }
    }
}