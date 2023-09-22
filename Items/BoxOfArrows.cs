using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class BoxOfArrows : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Box of Arrows");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 0, 60);
            Item.createTile = ModContent.TileType<Tiles.BoxOfArrows>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Other.BoxOfArrows)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<BoxOfArrows>());
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddIngredient(ItemID.WoodenArrow, 30);
            recipe.AddTile(TileID.WorkBenches);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}