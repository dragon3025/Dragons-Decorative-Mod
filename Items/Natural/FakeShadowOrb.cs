using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FakeShadowOrb : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Shadow Orb Object");
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
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Natural.FakeShadowOrb>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Natural.AltarsShadowOrbAndCrimsonHeart)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Natural.FakeShadowOrb>());
            recipe.AddIngredient(ItemID.EbonstoneBlock, 8);
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