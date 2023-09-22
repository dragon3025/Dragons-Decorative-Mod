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
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 2);
            Item.createTile = ModContent.TileType<Tiles.Natural.PeacefulPlanteraBulb>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Natural.PeacefulPlanteraBulb)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Natural.PeacefulPlanteraBulb>());
            recipe.AddIngredient(ItemID.ChlorophyteOre, 10);
            recipe.AddTile(TileID.CrystalBall);
            recipe.AddCondition(Condition.InGraveyard);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
