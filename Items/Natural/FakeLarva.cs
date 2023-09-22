using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FakeLarva : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fake Larva");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Blue;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = TileType<Tiles.Natural.FakeLarva>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Natural.FakeLarva)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Natural.FakeLarva>());
            recipe.AddIngredient(ItemID.Abeemination);
            recipe.AddIngredient(ItemID.BeeWax);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.AddCondition(Condition.InGraveyard);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}