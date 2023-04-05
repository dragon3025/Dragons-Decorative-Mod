using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeE
{
    public class BrokenGrandfatherClock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Broken Grandfather Clock");
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
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeE>();
            Item.placeStyle = 3;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().OtherAmbient)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ItemID.Wood)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Condition.InGraveyard)
              .Register();
        }
    }
}