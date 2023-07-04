using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class PeacefulPlanteraBulb : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Peaceful Plantera Bulb");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Lime;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 2);
            Item.createTile = ModContent.TileType<Tiles.Natural.PeacefulPlanteraBulb>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().PeacefulPlanteraBulb)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ItemID.ChlorophyteOre)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Condition.InGraveyard)
              .Register();
        }
    }
}