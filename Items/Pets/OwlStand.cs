using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Pets
{
    public class OwlStand : ModItem
    {
        public override void SetStaticDefaults()
        {
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
            Item.value = Item.sellPrice(0, 0, 10);
            Item.createTile = TileType<Tiles.Pets.OwlStand>();
        }

        public override bool CanUseItem(Player player)
        {
            switch (Main.rand.Next(4))
            {
                case 1:
                    Item.createTile = TileType<Tiles.Pets.OwlStand>();
                    break;
                case 2:
                    Item.createTile = TileType<Tiles.Pets.OwlStand2>();
                    break;
                case 3:
                    Item.createTile = TileType<Tiles.Pets.OwlStand3>();
                    break;
                default:
                    Item.createTile = TileType<Tiles.Pets.OwlStand4>();
                    break;
            }
            return true;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Pets.OwlStand)
            {
                return;
            }

            Recipe recipe = Recipe.Create(Type);
            recipe.AddIngredient(ItemID.Owl);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 2);
            recipe.AddTile(TileID.WorkBenches);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}