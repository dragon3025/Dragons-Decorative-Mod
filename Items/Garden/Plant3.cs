using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Garden
{
    public class Plant3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Plant");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 1, 50);
            Item.createTile = ModContent.TileType<Tiles.Garden.Plant>();
            Item.placeStyle = 4;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Garden.Plants)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<Garden.Plant3>());
            recipe.AddIngredient(ModContent.ItemType<SingleTilePlant3>());
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}
