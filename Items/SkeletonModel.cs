using DragonsDecorativeMod.Configuration;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class SkeletonModel : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Skeleton Model");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 54;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Orange;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 11, 80);
            Item.createTile = ModContent.TileType<Tiles.SkeletonModel>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<DragonsDecoModConfig>().Other.SkeletonModel)
            {
                return;
            }

            Recipe recipe = Recipe.Create(ItemType<SkeletonModel>());
            recipe.AddIngredient(ItemID.Bone, 206);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar);
            recipe.AddTile(TileID.HeavyWorkBench);
            if (GetInstance<DragonsDecoModConfig>().RequireCraftingKey)
            {
                recipe.AddCondition(Global.CraftingKeyCondition.HasCraftingKey);
            }
            recipe.Register();
        }
    }
}